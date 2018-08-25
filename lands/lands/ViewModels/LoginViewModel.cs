namespace lands.ViewModels
{
    using GalaSoft.MvvmLight.Command;
    using System.Windows.Input;
    using Xamarin.Forms;

    public class LoginViewModel : BaseViewModel
    {
        #region Attributes
        private string senha;
        private bool activity;
        private bool habilitado;
        #endregion

        #region Properties
        public string Email { get; set; }
        public string Senha {
            get { return this.senha; }
            set { SetValue(ref senha, value); }
        }
        public bool Activity {
            get { return this.activity; }
            set { SetValue(ref activity, value); }
        }
        public bool Lembrar { get; set; }
        public bool Habilitado {
            get { return this.habilitado; }
            set { SetValue(ref habilitado, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
        }

        public ICommand RegistrarCommand { get; set; }

        private async void Login()
        {
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

            this.Activity = true;
            this.Habilitado = false;

            if (this.Email != "dmoitim@gmail.com" || this.Senha != "1234")
            {
                this.Activity = false;
                this.Habilitado = true;

                await Application.Current.MainPage.DisplayAlert(
                    "Erro",
                    "Usuário ou senha inváidos.",
                    "OK");

                this.Senha = string.Empty;

                return;
            }

            this.Activity = false;
            this.Habilitado = true;

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
            this.Habilitado = true;
        }
        #endregion
    }
}
