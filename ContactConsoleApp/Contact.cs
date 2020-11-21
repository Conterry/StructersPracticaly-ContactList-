using System;
using System.Collections.Generic;
using System.Text;

namespace ContactConsoleApp
{
    struct Contact
    {
        public string Name;
        public string SecondName;
        public string Number;

        public Contact(string Name, string SecondName, string Number)
        {
            this.Name = Name;
            this.SecondName = SecondName;
            this.Number = Number;
        }
    }
}
