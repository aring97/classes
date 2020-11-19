using System;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Company companyOne=new Company("CompanyOne", DateTime.Now);
            companyOne.employeeList.Add(new Employee("John", "Alpha", "CEO"));
            companyOne.employeeList.Add(new Employee("Steve", "Bravo", "CFO"));
            companyOne.employeeList.Add(new Employee("Dave", "Charlie", "COO"));
            companyOne.listEmployees();
        }
    }
}
