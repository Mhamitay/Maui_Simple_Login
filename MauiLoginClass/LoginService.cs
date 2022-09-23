using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiLoginClassLib
{
    public class LoginService
    {
        public User signIn()
        {
            return new User { name="admin",password="123"};
        }
    }
}
