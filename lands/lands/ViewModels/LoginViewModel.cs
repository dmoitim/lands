namespace lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;
    using Xamarin.Forms;

    class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Activity { get; set; }
        public bool Lembrar { get; set; }
        #endregion

        #region Commands
        public ICommand LoginCommand {
            get
            {
                return new RelayCommand(Login);
            }
        }

        public ICommand RegistrarCommand { get; set; }

        private async void Login() {
            if (string.IsNullOrEmpty(this.Email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "Você deve informar o e-mail.",
                    "OK");

                return;
            }

            if (string.IsNullOrEmpty(this.Senha))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "Você deve informar a senha.",
                    "OK");

                return;
            }

            if (this.Email != "dmoitim@gmail.com" || this.Senha != "1234")
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "Usuário ou senha inváidos.",
                    "OK");

                return;
            }

            await Application.Current.MainPage.DisplayAlert(
                "Sucesso",
                "Seja bem vindo!",
                "OK");
        }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.Lembrar = true;
        }
        #endregion
    }
}
