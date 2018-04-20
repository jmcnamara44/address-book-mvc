using System.Collections.Generic;
using System.IO;
using System;

namespace AddressBook.Models
{
    public class Address
    {
        private string _streetAddress;
        private string _city;
        private string _state;
        private string _zipCode;

        public Address (string streetAddress, string city, string state, string zipCode)
        {
          _streetAddress = streetAddress;
          _city = city;
          _state = state;
          _zipCode = zipCode;
        }
        public string GetStreetAddress()
        {
          return _streetAddress;
        }
        public void SetStreetAddress(string newStreetAddress)
        {
          _streetAddress = newStreetAddress;
        }
        public string GetCity()
        {
          return _city;
        }
        public void SetCity(string newCity)
        {
          _city = newCity;
        }
        public string GetState()
        {
          return _state;
        }
        public void SetState(string newState)
        {
          _state = newState;
        }
        public string GetZipCode()
        {
          return _zipCode;
        }
        public void SetZipCode(string newZipCode)
        {
          _zipCode = newZipCode;
        }
    }
}
