using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookModel
{
    public class Diary
    {
        public string _Email { get; set; }
        public string _Fax { get; set; }
        public Address _Address { get; set; }
        public ContactNumber _ContactNumber { get; set; }

    }
}
