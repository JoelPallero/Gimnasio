using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class loginBussinessLayer
    {
        private readonly DataLogin _dataLogin;

        public loginBussinessLayer()
        {
            _dataLogin = new DataLogin();
        }
        public login_empleado SaveLogin(login_empleado login_empleado)
        {
            if (login_empleado.id == 0)
            {
                _dataLogin.CreatingLogin(login_empleado);
            }
            else
            {

            }
            return login_empleado;
        }

    }
}
