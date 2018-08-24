using System;
using System.Collections.Generic;
using System.Text;

namespace lands.Infrastructure
{
    using ViewModels;

    class InstanceLocator
    {
        #region Properties
        public MainViewModel Main { get; set; }
        #endregion

        #region Constructors
        public InstanceLocator()
        {
            this.Main = new MainViewModel();
        }
        #endregion
    }
}
