using System.Collections.Generic;
using System.IO;
using System;

namespace AddressBook.Models
{
  public class Addresses
  {
    private string _name;
    private string _address;
    private string _phoneNumber;
    private static int _id;
    private static List<Addresses> _contacts = new List<Addresses> {};

    public Addresses (string name, string address, string phoneNumber)
    {
      _name = name;
      _address = address;
      _phoneNumber = phoneNumber;
      _id = _contacts.Count;
    }
    public string GetName()
    {
      return _name;
    }
    public void SetName(string newName)
    {
      _name = newName;
    }
    public string GetAddress()
    {
      return _address;
    }
    public void SetAddress(string newAddress)
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
    public static List<Addresses> GetAll()
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
