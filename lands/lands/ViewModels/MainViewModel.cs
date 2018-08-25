﻿using System;
using System.Collections.Generic;
using System.Text;

namespace lands.ViewModels
{
    class MainViewModel
    {
        #region ViewModels
        public LoginViewModel Login { get; set; }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            this.Login = new LoginViewModel();
        }
        #endregion
    }
}
