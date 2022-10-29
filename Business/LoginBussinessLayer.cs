using DataAccess;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bussiness
{
    public class LoginBussinessLayer
    {
        private readonly DataLogin _dataLogin;

        public LoginBussinessLayer()
        {
            _dataLogin = new DataLogin();
        }

        //Registrar nuevo login
        public Login_empleado SaveLogin(Login_empleado _login_empleado)
        {
            if (_login_empleado.id == 0)
            {
                _dataLogin.CreatingLogin(_login_empleado);
            }
            else
            {

            }
            return _login_empleado;
        }

        //Consultar último login
        public Login_empleado ShowLastLogin(Login_empleado _login_Empleado)
        {
            return _dataLogin.ConsultarLogin(_login_Empleado);
        }

    }
}
