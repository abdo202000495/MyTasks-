using Day09;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Day09
{
    public  class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual decimal salary { get; set; }
        public string  _department { get; set; }

        public Person(int id,string name,string department)
        {
            Id= id;
            Name= name;
            _department= department;
        }

        public override string ToString()
        {
            return $"id  is {Id},Name of  {Name} ,department  is {_department}";
        }
    }

    public class Employee : Person
    {
        public Employee(int id, string name, string department) : base(id, name, department)
        {
            Department.department = this._department;
        }

        public sealed override decimal salary
        { 
            get
            {
                return base.salary+2000;
            }
            set
            {
                base.salary = value;
            }
        }

        public override bool Equals(object obj)
        {
            Employee emp = (Employee)obj;
            if ((emp.Id == this.Id) && (emp.Name == this.Name) && (emp._department == this._department))
                return true;
            else return false;
                
        }

        public  int CompareTo(object obj)
        {
            //casting 
            Employee emp = (Employee)obj;
            if (emp.salary == this.salary && emp.Name == this.Name && emp._department == this._department)
                return 1;
            else
                return -1;    
        }

      
    }


}

public class Name : Person
{
   

    public Name(int id, string name, string department) : base(id, name, department)
    {
    }

    public  override decimal salary
    {
        get
        {
            return base.salary + 4000;
        }
        set
        {
            base.salary = value;
        }
    }
}
