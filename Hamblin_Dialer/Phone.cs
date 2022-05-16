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

        }
        public string Dial()
        {
            if (_type == "1")
            {

            }
            if (_type == "2")
            {
                    
            }
            return _name + " is being dialed using " + _phoneNumber;
        }
    }
}
