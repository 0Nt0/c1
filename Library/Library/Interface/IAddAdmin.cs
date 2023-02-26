using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Interface
{
    internal interface IAddAdmin
    {
        public void AddAPerson(string smth);
        public int Exhists(string name, string pas, string smth);
    }
}
