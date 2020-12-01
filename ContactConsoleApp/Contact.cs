using System;
using System.Collections.Generic;
using System.Text;

namespace ContactConsoleApp
{
    public struct Contact
    {
        public string Name;
        public string Number;

        public static Contact NewContact()
        {
            Contact contact = new Contact();
            contact.Name = "no info";
            contact.Number = "no info";
            return contact;
        }
    }
}
