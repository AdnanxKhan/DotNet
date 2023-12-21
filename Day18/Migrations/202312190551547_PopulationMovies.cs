namespace MyApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulationMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (MovieId, MovieName,Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (3,'UNDISPUTED','ACTION',1990-06-21,2023-05-10,5)");
            Sql("INSERT INTO Movies (MovieId, MovieName,Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (4,'HARRY POTTER','FICTION',2000-11-01,2023-07-31,3)");
            Sql("INSERT INTO Movies (MovieId, MovieName,Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (5,'BREAKING BAD','SCI-FI',1990-06-21,2022-04-09,2)");
            Sql("INSERT INTO Movies (MovieId, MovieName,Genre, ReleaseDate, DateAdded, NumberInStock) VALUES (6,'YOUR NAME','ANIME',2016-07-11,2023-7-20,09)");
        }
        
        public override void Down()
        {
        }
    }
}
