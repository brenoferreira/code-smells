using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace Payroll
{
    public class Employees
    {
        public Employee GetBy(Func<Employee, Boolean>  expression)
        {
            return employees.Where(expression).SingleOrDefault();
        }

        //simulando banco de dados:
        private List<Employee> employees = new List<Employee>
                                               {
                                                   new Employee { Id = 1, SubsidiaryId = 999, TerminationDate = new DateTime(2010, 10, 1), Account = new CheckingsAccount(new AccountDetails(new Bank(7), 123))}, 
                                                   new Employee { Id = 2, SubsidiaryId = 3, TerminationDate = new DateTime(2010, 10, 1) , Account = new CheckingsAndSavingsAccount(new AccountDetails(new Bank(1), 1234))}, 
                                                   new Employee { Id = 3, SubsidiaryId = 999, Account = new CheckingsAccount(new AccountDetails(new Bank(2), 123))},
                                                   new Employee { Id = 4, SubsidiaryId = 999, Account = new SavingsAccount(new AccountDetails(new Bank(3), 123))},
                                                   new Employee { Id = 5, SubsidiaryId = 999, Account = new CheckingsAndSavingsAccount(new AccountDetails(new Bank(4), 123))}
                                               };
    }
}