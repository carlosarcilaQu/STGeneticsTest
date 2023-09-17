using CurrieTechnologies.Razor.SweetAlert2;
using static BlazorApp2.Sweetalert.SweetAlertClasses;

namespace BlazorApp2.Sweetalert
{
    public class SwaAlerts
    {

        private readonly SweetAlertService _sweetAlertService;

        public SwaAlerts(SweetAlertService sweetAlertService)
        {
            _sweetAlertService = sweetAlertService;
        }
        public void ShowWarningAlertWithImage(ShowErrorAlertWithImageclass showErrorAlertWithImageclass, Action<bool> onConfirm)
        {
            _sweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = showErrorAlertWithImageclass.Title,
                Text = showErrorAlertWithImageclass.Mensaje,
                ImageUrl = showErrorAlertWithImageclass.ImageUrl,
                ImageHeight = showErrorAlertWithImageclass.ImageHeight,
                ImageWidth = showErrorAlertWithImageclass.ImageWidth,
                ShowCancelButton = showErrorAlertWithImageclass.ShowCancelButton,
                ConfirmButtonText = showErrorAlertWithImageclass.ConfirmButtonText,
                ConfirmButtonColor = showErrorAlertWithImageclass.ConfirmButtonColor
            }).ContinueWith(result =>
            {
                // Comprueba si se ha confirmado la alerta y llama a la acción correspondiente.
                bool confirmed = result.Result.IsConfirmed;
                onConfirm?.Invoke(confirmed);
            });

        }
        public void ShowWarningAlertWithIcon(ShowWarningAlertWithIcon showWarningAlertWithIcon, Action<bool> onConfirm)
        {
            _sweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = showWarningAlertWithIcon.Title,
                Text = showWarningAlertWithIcon.Mensaje,
                Icon = SweetAlertIcon.Warning,
                IconColor = showWarningAlertWithIcon.IconColor,
                ShowCancelButton = false,
                ConfirmButtonText = showWarningAlertWithIcon.ConfirmButtonText,
                ConfirmButtonColor = showWarningAlertWithIcon.ConfirmButtonColor
            }).ContinueWith(result =>
            {
                // Comprueba si se ha confirmado la alerta y llama a la acción correspondiente.
                bool confirmed = result.Result.IsConfirmed;
                onConfirm?.Invoke(confirmed);
            });
        }
        public void ShowWarningErrorWithIcon(ShowWarningAlertWithIcon showWarningAlertWithIcon)
        {
            _sweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = showWarningAlertWithIcon.Title,
                Text = showWarningAlertWithIcon.Mensaje,
                Icon = SweetAlertIcon.Error,
                IconColor = showWarningAlertWithIcon.IconColor,
                ShowCancelButton = false,
                ConfirmButtonText = showWarningAlertWithIcon.ConfirmButtonText,
                ConfirmButtonColor = showWarningAlertWithIcon.ConfirmButtonColor
            });
        }
        public void ShowWarningAlertWithImageInformative(ShowErrorAlertWithImageInformativeclass showErrorAlertWithImageclass)
        {
            _sweetAlertService.FireAsync(new SweetAlertOptions
            {
                Title = showErrorAlertWithImageclass.Title,
                Text = showErrorAlertWithImageclass.Mensaje,
                ImageUrl = showErrorAlertWithImageclass.ImageUrl,
                ImageHeight = showErrorAlertWithImageclass.ImageHeight,
                ImageWidth = showErrorAlertWithImageclass.ImageWidth,
                ShowCancelButton = false,
                ConfirmButtonText = showErrorAlertWithImageclass.ConfirmButtonText,
                ConfirmButtonColor = showErrorAlertWithImageclass.ConfirmButtonColor
            });

        }
    }
}
