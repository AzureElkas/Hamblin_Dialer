using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_Dialer
{
    abstract class Phone
    {
        string _name;
        string _phoneNumber;
        string _type;
        public  Phone(string Name, string PhoneNumber, string Type)
        {
            _name = Name;
            _phoneNumber = PhoneNumber;
            _type = Type;
        }
        public string Dial()
        {
            return _name;
        }
    }
}
