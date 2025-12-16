using System;
using System.Collections.Generic;
using System.Text;

namespace CManager.Domain.Models;

//Klass som inninnehåller den information som behövs för att hantera kund
//med allt från unikt id för varje kund som skapats med guid till komplett adressobjekt tillhörande kund

public class CustomerModel
{
    public Guid Id { get; set; } = Guid.NewGuid();
    public string FirstName { get; set; } = null!;
    public string LastName { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PhoneNumber { get; set; } = null!;
    public AddressModel Address { get; set; } = new AddressModel();
}

