using Blazored.FluentValidation;
using MinhasNoticias.Application.Requests.Identity;
using Microsoft.AspNetCore.Components.Authorization;
using MudBlazor;
using System.Security.Claims;
using System.Threading.Tasks;

namespace MinhasNoticias.Client.Pages.Authentication
{
    public partial class Login
    {
        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });
        private TokenRequest _tokenModel = new();

        protected override async Task OnInitializedAsync()
        {
            var state = await _stateProvider.GetAuthenticationStateAsync();
            if (state?.User?.Identity?.IsAuthenticated == true)
            {
                _navigationManager.NavigateTo("/home");
            }
        }

        private async Task SubmitAsync()
        {
            var result = await _authenticationManager.Login(_tokenModel);
            if (!result.Succeeded)
            {
                foreach (var message in result.Messages)
                {
                    _snackBar.Add(message, Severity.Error);
                }
            }
        }

        private bool _passwordVisibility;
        private InputType _passwordInput = InputType.Password;
        private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;

        void TogglePasswordVisibility()
        {
            if (_passwordVisibility)
            {
                _passwordVisibility = false;
                _passwordInputIcon = Icons.Material.Filled.VisibilityOff;
                _passwordInput = InputType.Password;
            }
            else
            {
                _passwordVisibility = true;
                _passwordInputIcon = Icons.Material.Filled.Visibility;
                _passwordInput = InputType.Text;
            }
        }

    }
}