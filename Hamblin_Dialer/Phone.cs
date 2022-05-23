using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_Dialer
{
    abstract class Phone
    {
        private string _name;
        private string _phoneNumber;
        private string _type;
        public Phone(string Name, string PhoneNumber, string Type)
        {
            _name = Name;
            _phoneNumber = PhoneNumber;
            _type = Type;
        }
        public virtual string Dial()
        {
            return _name + " is being dialed using " + _phoneNumber + "...";
        }
        protected string GetName()
        {
            return _name;
        }
        protected string GetNumber()
        {
            return _phoneNumber;
        }
        //Left public only as an example of how it could be used potentially in another scenario, finding the type of the object in the array
        public string GetPhoneType()
        {
            return _type;
        }
    }
}
