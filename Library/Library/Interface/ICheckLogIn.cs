using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interface
{
    internal interface ICheckLogIn
    {
        public string UserInfo(string username, string password);
    }
}
