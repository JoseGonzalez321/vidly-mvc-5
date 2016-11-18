namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SetBirthdateCustomers : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Customers SET Birthdate = CAST('1980-01-21' AS DATETIME) WHERE Id = 1");
            Sql("UPDATE Customers SET Birthdate = CAST('2000-12-12' AS DATETIME) WHERE Id = 3");
        }
        
        public override void Down()
        {
        }
    }
}
