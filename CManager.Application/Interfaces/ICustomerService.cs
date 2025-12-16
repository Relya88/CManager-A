using CManager.Domain.Models;
using System.Collections.Generic;

namespace CManager.Application.Interfaces;

public interface ICustomerService
{
    //Skapar ny kund
    bool CreateCustomer(
        string firstName, 
        string lastName, 
        string email, 
        string phoneNumber, 
        string streetAddress, 
        string postalCode, 
        string city);

    //hämtar alla kunder
    IEnumerable<CustomerModel> GetAllCustomers(out bool hasError);
    //hämtar specifik kund baserat på email
    CustomerModel? GetCustomerByEmail(string email);
    //tar bort kund baserat på email 
    bool DeleteCustomer(string email);
}
