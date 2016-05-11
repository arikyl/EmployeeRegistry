namespace EmployeeRegister.Migrations
{
    using Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<EmployeeRegister.DataAccessLayer.EmployeesContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(EmployeeRegister.DataAccessLayer.EmployeesContext context)
        {

            context.Employees.AddOrUpdate(
              e => e.FirstName,
              new Employee { FirstName = "Adam", LastName = "Andersson", Salary = 35000, Position = "Prpgrammerare", Department = "IT-avdelningen" },
              new Employee { FirstName = "Bo", LastName = "Bengtsson", Salary = 40000, Position = "Prpgrammerare", Department = "IT-avdelningen" },
              new Employee { FirstName = "Carl", LastName = "Carlsson", Salary = 40000, Position = "Controller", Department = "Ekonomi-avdelningen" },
              new Employee { FirstName = "Diana", LastName = "Danielsson", Salary = 35000, Position = "Rekryterare", Department = "HR-avdelningen" },
              new Employee { FirstName = "Erik", LastName = "Eriksson", Salary = 45000, Position = "Projektledare", Department = "IT-avdelningen" }
              );
        }
    }
}
