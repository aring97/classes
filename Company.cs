using System;
using System.Collections.Generic;
namespace classes{
    public class Company{
        public Company(string name, DateTime date){
            _dateFounded=date;
            _companyName=name;
        }
        private DateTime _dateFounded{get; set;}
        private string _companyName{get; set;}
        public List<Employee> employeeList=new List<Employee>();

        public void listEmployees(){
            foreach(Employee employee in employeeList){
                System.Console.WriteLine($"{employee.fullName} works for {_companyName} as {employee.title} since {employee.startDate}.");
            }
        }
    }
}