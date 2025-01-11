using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_oop_3
{
    #region 1.Design and implement a Class for the employees in a company:
    internal class Employee
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public SecurityLevel SecurityLevel { get; set; }
        public double Salary { get; set; }
        public DateTime HiringDate { get; set; }
        public Gender Gender { get; set; }
        public SecurityPrivileges SecurityPrivileges { get; set; }
        public Employee(int id, string name, SecurityLevel securitylevel, double salary, DateTime hiredate, Gender gender, SecurityPrivileges securityprivileges)
        {
            Id = id;
            Name = name;
            SecurityLevel = securitylevel;
            Salary = salary;
            HiringDate = hiredate;
            Gender = gender;
            SecurityPrivileges = securityprivileges;

        }
        public override string ToString()
        {
            return $"ID = {Id}\nName = {Name}\nSecurityLevel = {SecurityLevel}\nSalary = {Salary:c}\nHiringDate = {HiringDate}\nGender = {Gender}\nSecurityPrivileges = {SecurityPrivileges}";
        }
    }
    #endregion
}
