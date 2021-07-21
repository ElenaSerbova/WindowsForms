using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lists
{
    class PersonRegister
    {
        public BindingList<Person> Contacts { get; set; }

        public PersonRegister()
        {
            Contacts = new BindingList<Person>
            {
                new Person{ FirstName = "John", LastName = "Snow", Phone = "111-11-11"},
                new Person{ FirstName = "Sansa", LastName = "Stark", Phone = "222-22-22"},
                new Person{ FirstName = "Aria", LastName = "Stark", Phone = "333-33-33"},
            };
        }

    }
}
