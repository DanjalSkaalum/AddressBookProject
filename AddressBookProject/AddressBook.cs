using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookProject
{
    internal class AddressBook
    {
        string _Owner;
        List<Address> _Addresses;

        public string Owner { get { return _Owner; } set {_Owner = value;} }

        public AddressBook(string owner)
        {
            _Owner = owner;
            _Addresses = new List<Address>();
        }

        public void AddAddress(Address address)
        {
            _Addresses.Add(address);
        }
        public override string ToString()
        {
            string AddressInfo = string.Join("", _Addresses);
            return $"{Owner}:\n\n{AddressInfo}";
        }
        public void RemoveAddress(Address address)
        {
            _Addresses.Remove(address);
        }
    }
}
