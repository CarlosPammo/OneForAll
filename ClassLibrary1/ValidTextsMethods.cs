using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text;

namespace ClassLibrary1
{
    public class ValidTextsMethods
    {
        /*public Class1()
        { }*/
        public bool IsValid(string Text)
        {
            int number;
            bool isValid = int.TryParse(Text, out number);
            return isValid;
        }
    }
}
