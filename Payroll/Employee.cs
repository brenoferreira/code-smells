using System;

namespace Payroll
{
    public class Employee
    {
        public int Id { get; set; }

        public DateTime? TerminationDate { get; set; }

        public int SubsidiaryId { get; set; }

        public IAccount Account { get; set; }

        public Boolean IsActive()
        {
            return TerminationDate == null && SubsidiaryId == 999;
        }
    }
}