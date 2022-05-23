using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hamblin_Dialer
{
    class CellPhone : Phone
    {
        public CellPhone(string Name, string PhoneNumber, string Type) : base(Name, PhoneNumber, Type)
        {

        }
        public override string Dial()
        {
            return GetName() + " is being dialed using 1+" + GetNumber() + "...";
        }
    }
}
