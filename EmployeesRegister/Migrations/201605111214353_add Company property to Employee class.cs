namespace EmployeeRegister.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addCompanypropertytoEmployeeclass : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employees", "Company", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employees", "Company");
        }
    }
}
