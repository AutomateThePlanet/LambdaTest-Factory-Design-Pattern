﻿using System.Collections.Generic;

namespace RepositoryDesignPatternTests.Models;
public class Employee
{
    public Employee()
    {
        Customers = new HashSet<Customer>();
        InverseReportsToNavigation = new HashSet<Employee>();
    }

    public long EmployeeId { get; set; }
    public string LastName { get; set; }
    public string FirstName { get; set; }
    public string Title { get; set; }
    public long? ReportsTo { get; set; }
    public string BirthDate { get; set; }
    public string HireDate { get; set; }
    public string Address { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Country { get; set; }
    public string PostalCode { get; set; }
    public string Phone { get; set; }
    public string Fax { get; set; }
    public string Email { get; set; }

    public Employee ReportsToNavigation { get; set; }
    public ICollection<Customer> Customers { get; set; }
    public ICollection<Employee> InverseReportsToNavigation { get; set; }
}
