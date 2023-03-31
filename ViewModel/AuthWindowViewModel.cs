using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace craft.ViewModel
{
    public class AuthWindowViewModel:BaseViewModel
    {
        private string _login;
        private string _password;

        public string Login
        {
            get => _login;
            set
            {
                _login = value;
                OnPropertyChanged(nameof(Login))
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                Password = value;
                OnPropertyChanged(nameof(Password));
            }
        }
    }
}
