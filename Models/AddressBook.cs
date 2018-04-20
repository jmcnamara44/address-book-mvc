using System.Collections.Generic;
using System.IO;
using System;

namespace AddressBook.Models
{
    public class Contact
    {
        private string _name;
        private Address _address;
        private string _phoneNumber;
        private static int _id;
        private static List<Contact> _contacts = new List<Contact> {};

        public Contact (string name, Address address, string phoneNumber)
        {
          _name = name;
          _address = address;
          _phoneNumber = phoneNumber;
          _id = _contacts.Count;  //there is a better way to do this but cannot remember how.  want to use this to bring user to a page for just this object but haven't been able to get it to work yet
        }
        public string GetName()
        {
          return _name;
        }
        public void SetName(string newName)
        {
          _name = newName;
        }
        public Address GetAddress()
        {
          return _address;
        }
        public void SetAddress(Address newAddress)
        {
          _address = newAddress;
        }
        public string GetPhoneNumber()
        {
          return _phoneNumber;
        }
        public void SetPhoneNumber(string newPhoneNumber)
        {
          _phoneNumber = newPhoneNumber;
        }
        public static List<Contact> GetAll()
        {
          return _contacts;
        }
        public void Save()
        {
          _contacts.Add(this);
        }
        public static void ClearAll()
        {
          _contacts.Clear();
        }

    }
}
