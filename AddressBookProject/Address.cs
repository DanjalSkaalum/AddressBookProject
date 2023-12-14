using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    internal class Address
    {

        string _Name;
        string _StreetAddress;
        string _Telephone;

        public string Name { get { return _Name; } set { _Name = value; } }
        public string StreetAddress { get { return _StreetAddress; } set { _StreetAddress = value; } }
        public string Telephone { get { return _Telephone; } set { _Telephone = value; } }

        public Address(string name, string streetAddress, string telephone)
        {
            _Name = name;
            _StreetAddress = streetAddress;
            _Telephone = telephone;
        }

        public override string ToString()
        {
            return $"{Name}, {StreetAddress}, {Telephone}\n";
        }
    }
}
