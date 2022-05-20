using MinhasNoticias.Application.Interfaces.Services;
using MinhasNoticias.Infrastructure.Contexts;
using MinhasNoticias.Infrastructure.Helpers;
using MinhasNoticias.Infrastructure.Models.Identity;
using MinhasNoticias.Shared.Constants.Permission;
using MinhasNoticias.Shared.Constants.Role;
using MinhasNoticias.Shared.Constants.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Localization;
using Microsoft.Extensions.Logging;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace MinhasNoticias.Infrastructure
{
    public class DatabaseSeeder : IDatabaseSeeder
    {
        private readonly ILogger<DatabaseSeeder> _logger;
        private readonly IStringLocalizer<DatabaseSeeder> _localizer;
        private readonly ApplicationContext _db;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<AppRole> _roleManager;

        public DatabaseSeeder(
            UserManager<AppUser> userManager,
            RoleManager<AppRole> roleManager,
            ApplicationContext db,
            ILogger<DatabaseSeeder> logger,
            IStringLocalizer<DatabaseSeeder> localizer)
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _db = db;
            _logger = logger;
            _localizer = localizer;
        }

        public void Initialize()
        {
            AddAdministrator();
            AddBasicUser();
            _db.SaveChanges();
        }

        private void AddAdministrator()
        {
            Task.Run(async () =>
            {
                //Check if Role Exists
                var adminRole = new AppRole(RoleConstants.AdministratorRole, _localizer["Função de administrador com permissões totais"]);
                var adminRoleInDb = await _roleManager.FindByNameAsync(RoleConstants.AdministratorRole);
                if (adminRoleInDb == null)
                {
                    await _roleManager.CreateAsync(adminRole);
                    adminRoleInDb = await _roleManager.FindByNameAsync(RoleConstants.AdministratorRole);
                    _logger.LogInformation(_localizer["Função de administrador com permissões totais."]);
                }
                //Check if User Exists
                var superUser = new AppUser
                {
                    FirstName = "Admin",
                    LastName = "",
                    Email = "tasso@cerradoinformatica.com.br",
                    UserName = "admin",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    CreatedOn = DateTime.Now,
                    IsActive = true
                };
                var superUserInDb = await _userManager.FindByEmailAsync(superUser.Email);
                if (superUserInDb == null)
                {
                    await _userManager.CreateAsync(superUser, UserConstants.DefaultPassword);
                    var result = await _userManager.AddToRoleAsync(superUser, RoleConstants.AdministratorRole);
                    if (result.Succeeded)
                    {
                        _logger.LogInformation(_localizer["Usuário SuperAdmin padrão propagado."]);
                    }
                    else
                    {
                        foreach (var error in result.Errors)
                        {
                            _logger.LogError(error.Description);
                        }
                    }
                }
                foreach (var permission in Permissions.GetRegisteredPermissions())
                {
                    await _roleManager.AddPermissionClaim(adminRoleInDb, permission);
                }
            }).GetAwaiter().GetResult();
        }

        private void AddBasicUser()
        {
            Task.Run(async () =>
            {
                //Check if Role Exists
                var basicRole = new AppRole(RoleConstants.BasicRole, _localizer["Funções basicas com permissões padrão"]);
                var basicRoleInDb = await _roleManager.FindByNameAsync(RoleConstants.BasicRole);
                if (basicRoleInDb == null)
                {
                    await _roleManager.CreateAsync(basicRole);
                    _logger.LogInformation(_localizer["Papel Básico Semeado."]);
                }
                //Check if User Exists
                var basicUser = new AppUser
                {
                    FirstName = "Usuario",
                    LastName = "Comum",
                    Email = "cerrado@cerradoinformatica.com.br",
                    UserName = "cerrado",
                    EmailConfirmed = true,
                    PhoneNumberConfirmed = true,
                    CreatedOn = DateTime.Now,
                    IsActive = true
                };
                var basicUserInDb = await _userManager.FindByEmailAsync(basicUser.Email);
                if (basicUserInDb == null)
                {
                    await _userManager.CreateAsync(basicUser, UserConstants.DefaultPassword);
                    await _userManager.AddToRoleAsync(basicUser, RoleConstants.BasicRole);
                    _logger.LogInformation(_localizer["Funções basicas com permissões padrão."]);
                }
            }).GetAwaiter().GetResult();
        }
    }
}