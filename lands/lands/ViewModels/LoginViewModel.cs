namespace lands.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Windows.Input;

    class LoginViewModel
    {
        #region Properties
        public string Email { get; set; }
        public string Senha { get; set; }
        public bool Activity { get; set; }
        public bool Lembrar { get; set; }
        #endregion

        #region Commands
        public ICommand LoginCommand { get; set; }
        public ICommand RegistrarCommand { get; set; }
        #endregion

        #region Constructors
        public LoginViewModel()
        {
            this.Lembrar = true;
        }
        #endregion
    }
}
