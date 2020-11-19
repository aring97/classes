using System;
namespace classes{
    public class Employee{
        public Employee(){

        }
        public Employee(string firstName, string lastName, string title){
            _firstName=firstName;
            _lastName=lastName;
            this.title=title;
            startDate=DateTime.Now;
        }
        private string _firstName{get; set;}
        private string _lastName{get; set;}
        public string title{get; set;}
        public DateTime startDate{get; set;}
        public string fullName{
            get{
                return $"{_firstName} {_lastName}";
            }
        }
    }
}