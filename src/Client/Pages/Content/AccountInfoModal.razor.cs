using MinhasNoticias.Application.Requests.Identity;
using Microsoft.AspNetCore.Components;
using MudBlazor;
using System.Threading.Tasks;
using Blazored.FluentValidation;
using MinhasNoticias.Application.Responses.Identity;

namespace MinhasNoticias.Client.Pages.Content
{
    public partial class AccountInfoModal
    {
        private FluentValidationValidator _fluentValidationValidator;
        private bool Validated => _fluentValidationValidator.Validate(options => { options.IncludeAllRuleSets(); });
        [CascadingParameter] private MudDialogInstance MudDialog { get; set; }
        [Parameter] public string UserId { get; set; }
        private UserResponse _accountInfoModel { get; set; } = new();

        protected override async Task OnInitializedAsync()
        {
            var result = await _userManager.GetAsync(UserId);
            if (result.Succeeded)
            {
                _accountInfoModel = result.Data;
            }
        }
        private void Cancel()
        {
            MudDialog.Cancel();
        }

        private async Task SubmitAsync()
        {
            _snackBar.Add("For demo purpose only!", Severity.Info);
            MudDialog.Close();
        }

        private bool _passwordVisibility;
        private InputType _passwordInput = InputType.Password;
        private string _passwordInputIcon = Icons.Material.Filled.VisibilityOff;

        private void TogglePasswordVisibility()
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