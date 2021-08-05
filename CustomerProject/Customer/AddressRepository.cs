using CustomerProject.Customer;
using System.Collections.Generic;

namespace CustomerProject.Customer
{
  public class AddressRepository
  {
    public Address Retrieve(int addressId)
    {
      Address address = new Address(addressId);

      if (addressId == 1)
      {
        address.AddressType = 1;
        address.StreetLine1 = "MES Colony";
        address.StreetLine2 = "khadki";
        address.City = "Pune";
        address.State = "Maharashtra";
        address.Country = "India";
        address.PostalCode = "411003";

      }
      return address;
    }

    public IEnumerable<Address> RetrieveByCustomerId(int customerId)
    {
      var addressList = new List<Address>();
      Address address = new Address(1)
      {
        AddressType = 1,
        StreetLine1 = "MES Colony",
        StreetLine2 = "Khadki",
        City = "Pune",
        State = "Maharashtra",
        Country = "India",
        PostalCode = "411003"
      };
      addressList.Add(address);

      address = new Address(2)
      {
        AddressType = 2,
        StreetLine1 = "Goa beach",
        City = "Goa City",
        State = "Maharashtra",
        Country = "India",
        PostalCode = "144566"
      };
      addressList.Add(address);

      return addressList;
    }
    public bool Save(Address address)
    {
      return true;
    }
  }
}
