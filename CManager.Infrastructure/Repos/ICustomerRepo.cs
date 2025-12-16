using CManager.Domain.Models;

namespace CManager.Infrastructure.Repos;

//Interfacet för kundrepot med ansvar att spara och hämta kunder från lagringen
//listn hämtar kunder från jsonfil och returnerar dem som lista och boolen returnerar om sparnigenn lyckades
public interface ICustomerRepo
{
    List<CustomerModel> GetAllCustomers();

    bool SaveCustomers(List<CustomerModel> customers);
}