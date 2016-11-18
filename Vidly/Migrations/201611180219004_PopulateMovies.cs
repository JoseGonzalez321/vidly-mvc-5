namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql(@"INSERT INTO Movies (Name, DateAdded, ReleaseDate, NumberInStock, GenreId) 
                              VALUES ('Shrek', GETDATE(), CAST('2001-04-22' AS DATETIME), 5, 5)");
            Sql(@"INSERT INTO Movies (Name, DateAdded, ReleaseDate, NumberInStock, GenreId) 
                              VALUES ('Ip Man', GETDATE(), CAST('2010-10-01' AS DATETIME), 10, 1)");
            Sql(@"INSERT INTO Movies (Name, DateAdded, ReleaseDate, NumberInStock, GenreId) 
                              VALUES ('Seven', GETDATE(), CAST('1995-09-22' AS DATETIME), 2, 2)");
        }
        
        public override void Down()
        {
        }
    }
}
