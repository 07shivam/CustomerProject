using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerProject.Customer
{
  public class CustomerRepository
  {
    public CustomerRepository()
    {
      addressRepository = new AddressRepository();
    }

    private AddressRepository addressRepository { get; set; }

    public Customer Retrieve(int customerId)
    {
      Customer customer = new Customer(customerId);

      if (customerId == 1)
      {
        customer.EmailAddress = "shivam.bhargava7@gmail.com";
        customer.FirstName = "Shivam";
        customer.LastName = "Bhargava";
        customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();
      }
      return customer;
    }
    public bool Save(Customer customer)
    {


      return true;
    }

  }
}
