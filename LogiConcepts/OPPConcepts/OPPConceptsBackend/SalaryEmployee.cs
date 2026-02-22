using System;
using System.Collections.Generic;
using System.Text;

namespace OPPConceptsBackend;

public class SalaryEmployee : Employee
{
    //Fields
    private decimal _salary;

  

    //Contructors
    public SalaryEmployee(int id, string firstName, string lastName, bool isActive, Date bornDate, Date hireDate, decimal salary) : 
        base(id, firstName, lastName, isActive, bornDate, hireDate)
    {
        Salary = salary;
    }

    //Properties

    public decimal Salary
    {
        get => _salary;
        set => _salary = ValidateSalary(value);
    }

    //Methods
    public override decimal GetValueTopay() => Salary;

    public override string ToString() => base.ToString();

    private decimal ValidateSalary(decimal salary)
    {
        if (salary < 2000000)
        {
            throw new ArgumentOutOfRangeException(nameof(salary), "Salary must be greater than or equal to 2,000,000.");
        }
        return salary;
    }
}
