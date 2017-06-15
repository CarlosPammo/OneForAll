using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookModel
{
    public class Contact
    {
        public string _Name { get; set; }
        public string _Lastname { get; set; }
        public DateTime Birthday { get; set; }
        public Diary _Diary { get; set; }
        public string _TypeContact { get; set; }

    }
}
