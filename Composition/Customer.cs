using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Composition
{
    public class Customer : Entity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public override string ToString()
        {
            return string.Format("{2}, {1}, {0}", ID, FirstName, LastName);
        }
    }
}
