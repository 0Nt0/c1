using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library
{
    internal interface userInterface
    {
        public string Name { get; set;}
        public string LName { get; set; }
        public string role { get; set; }
        public string password { get; set; }
    }
}
