using System;
using System.Collections.Generic;

namespace Composite
{
    class Program
    {
        static void Main(string[] args)
        {

            var analyst1 = new Analyst(3000);
            var analyst2 = new Analyst(3500);

            var analystLead = new AnalystTeamLead(7000);

            analystLead.Employees.Add(analyst1);
            analystLead.Employees.Add(analyst2);

            var developer1 = new Developer(6000);
            var developer2 = new Developer(7000);

            var developerTeamLead = new DeveloperTeamLead(10000);

            developerTeamLead.Employees.Add(developer1);
            developerTeamLead.Employees.Add(developer2);

            var ITDirector = new ITDirector(15000);

            ITDirector.Employees.Add(analystLead);
            ITDirector.Employees.Add(developerTeamLead);

            var cdo = new CDO(50000);

            cdo.Employees.Add(ITDirector);

            cdo.DisplaySalary();


            Console.ReadLine();
        }
    }

    /// <summary>
    /// Component abstract class
    /// </summary>
    public abstract class Person
    {
        public int Salary { get; set; }

        public List<Person> Employees { get; set; }

        public Person(int salary)
        {
            Salary = salary;
            Employees = new List<Person>();
        }

        public void DisplaySalary()
        {

            Console.WriteLine(this.GetType().Name + ": " + this.Salary.ToString() + " salary.");
            foreach (var emp in this.Employees)
            {
                emp.DisplaySalary();
            }
        }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class Analyst : Person
    {
        public Analyst(int salary) : base(salary) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class Developer : Person
    {
        public Developer(int salary) : base(salary) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class AnalystTeamLead : Person
    {
        public AnalystTeamLead(int salary) : base(salary) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class DeveloperTeamLead : Person
    {
        public DeveloperTeamLead(int salary) : base(salary) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class ITDirector : Person
    {
        public ITDirector(int salary) : base(salary) { }
    }

    /// <summary>
    /// Leaf class
    /// </summary>
    public class CDO : Person
    {
        public CDO(int salary) : base(salary) { }
    }


}
