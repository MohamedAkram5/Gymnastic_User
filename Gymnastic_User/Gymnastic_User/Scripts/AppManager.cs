using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Gymnastic_User
{
    class AppManager
    {
        private static AppManager _instance;
        public static AppManager Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AppManager();
                return _instance;
            }
        }
        
        public Page page1 { get; set; }
        public Page page2 { get; set; }

        public AppManager()
        {
            _instance = this;
            page1 = new Page1() { IsEnabled = false }; 
            page2 = new Page2() { IsEnabled = false };
        }

    }
}
