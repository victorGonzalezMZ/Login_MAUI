using Login_MAUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_MAUI.Interfaces
{
    interface ILogin
    {
        Task<Login> Authenticate(UserMin user);
    }
}
