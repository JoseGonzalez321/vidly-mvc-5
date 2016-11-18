namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovieCoverUrl : DbMigration
    {
        public override void Up()
        {
            Sql("UPDATE Movies SET CoverUrl = 'http://t2.gstatic.com/images?q=tbn:ANd9GcS_OkJKQ6ZpDV_xhC0L9zyHEcKMlV9x3Q30LF6MOE0nV1U6r09p' WHERE Id = 3");
            Sql("UPDATE Movies SET CoverUrl = 'http://www.gstatic.com/tv/thumb/movieposters/3586588/p3586588_p_v8_aa.jpg' WHERE Id = 4");
            Sql("UPDATE Movies SET CoverUrl = 'http://t2.gstatic.com/images?q=tbn:ANd9GcRod45bAdo2Os6THPDA2qDH2qIwNtqBlrjfZGGn_J2ppx6DIhhU' WHERE Id = 5");
        }
        
        public override void Down()
        {
        }
    }
}
