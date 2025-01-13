namespace assignment_oop_3
{
    internal class Program
    {
        static void Main(string[] args)
            #region 1.	Design and implement a Class for the employees in a company:
        {
            //Employee employee = new Employee(1, "mohamed", SecurityLevel.Read, 7590, DateTime.Now, Gender.male, SecurityPrivileges.Developer);

            //Console.WriteLine(employee);
            #endregion
            #region 2.Develop a Class to represent the Hiring Date Data:•	Consisting of fields to hold the day, month and Years.

            HiringDateData hiringDateData = new HiringDateData(101, 10, 20101);
            if (hiringDateData.Day == 0 || hiringDateData.Month == 0 || hiringDateData.Year == 0)
            {
                Console.WriteLine("Invalid date");
            }
            else
            {
                Console.WriteLine(hiringDateData);
            }
            #endregion

            #region 3-Create an array of Employees with size three a DBA, Guest and the third one is security officer who have full permissions. (Employee [] EmpArr;)
            //Employee[] employees = new Employee[3];
            //employees[0] = new Employee(1, "mohamed", SecurityLevel.Write | SecurityLevel.Delete, 25470, new DateTime(2010 , 01 , 05), Gender.male, SecurityPrivileges.DBA);
            //employees[1] = new Employee(2, "ahmed", SecurityLevel.Read, 10520, new DateTime(2017 , 11 , 17), Gender.female, SecurityPrivileges.Guest);
            //employees[2] = new Employee(3, "kamal", SecurityLevel.FullAccess, 40000, new DateTime(2007 , 01 , 01), Gender.male, SecurityPrivileges.SecurityOfficer);
            //foreach (Employee employee in employees)
            //{
            //    Console.WriteLine(employee);
            //    Console.WriteLine("---------------------------");
            //}
            #endregion

            #region 4-Sort the employees based on their hire date then Print the sorted array.
            //    Employee[] employee = new Employee[]
            //    {
            //         new Employee(1, "mohamed", SecurityLevel.Write | SecurityLevel.Delete, 25470, new DateTime(2010 , 01 , 05), Gender.male, SecurityPrivileges.DBA),
            //         new Employee(2, "ahmed", SecurityLevel.Read, 10520, new DateTime(2017 , 11 , 17), Gender.female, SecurityPrivileges.Guest),
            //         new Employee(3, "kamal", SecurityLevel.FullAccess, 40000, new DateTime(2007 , 01 , 01), Gender.male, SecurityPrivileges.SecurityOfficer),


            //};
            //    Array.Sort(employee, (emp1, emp2) => emp1.HiringDate.CompareTo(emp2.HiringDate));
            //    foreach (Employee emp in employee)
            //    {
            //        Console.WriteLine(emp);
            //    }
            //     //•	While sorting (how many times Boxing and Unboxing process has occurred) مش فاهم المفروض ايه يتعمل هنا ف هحضره في الوورك شوب

            #endregion
            #region 5-Design a program for a library management system where:
            //EBook eBook = new EBook("mohamed ahmed", "dotnet", "25f724as267", 4762.20);
            //PrintedBook printedBook = new PrintedBook("ahmed kamal", "php", "27as6e4921ed", 777);
            //Console.WriteLine(eBook);
            //Console.WriteLine("---------------------");
            //Console.WriteLine(printedBook);
            #endregion
        }
    }
}

