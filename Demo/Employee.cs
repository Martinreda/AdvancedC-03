using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    internal class Employee :IComparable<Employee>
    {


        public int Id { get; set; }
        public string? Name { get; set; }
        public double Salary { get; set; }

        public Employee(int id, string? name, double salary)
        {
            Id = id;
            Name = name;
            Salary = salary;
        }
        public override string ToString()
        {
            return $"Id : {Id} | Name : {Name} | Salary : {Salary}";

        }
        public override bool Equals(object? obj)
        {
            Employee? emp = obj as Employee;
            if (emp is null) return false;
            return Id == emp.Id && Name == emp.Name && Salary == emp.Salary;
        }
        public override int GetHashCode()
        {
            return HashCode.Combine(Id, Name, Salary);
        }

        public int CompareTo(Employee? other)
        {
            if (other == null) return 1;
            return this.Id.CompareTo(other.Id);
        }
    }
}
