using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace AracTescil.Migrations
{
    public partial class SeedDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO Markalar (Ad) VALUES ('Marka1')");
            migrationBuilder.Sql("INSERT INTO Markalar (Ad) VALUES ('Marka2')");
            migrationBuilder.Sql("INSERT INTO Markalar (Ad) VALUES ('Marka3')");

            migrationBuilder.Sql("INSERT INTO Modeller (Ad, MarkaId) VALUES ('Marka1-ModelA', (SELECT Id FROM Markalar Where Ad='Marka1'))");
            migrationBuilder.Sql("INSERT INTO Modeller (Ad, MarkaId) VALUES ('Marka1-ModelB', (SELECT Id FROM Markalar Where Ad='Marka1'))");
            migrationBuilder.Sql("INSERT INTO Modeller (Ad, MarkaId) VALUES ('Marka1-ModelC', (SELECT Id FROM Markalar Where Ad='Marka1'))");
                                                                                                                             
            migrationBuilder.Sql("INSERT INTO Modeller (Ad, MarkaId) VALUES ('Marka2-ModelA', (SELECT Id FROM Markalar Where Ad='Marka2'))");
            migrationBuilder.Sql("INSERT INTO Modeller (Ad, MarkaId) VALUES ('Marka2-ModelB', (SELECT Id FROM Markalar Where Ad='Marka2'))");
            migrationBuilder.Sql("INSERT INTO Modeller (Ad, MarkaId) VALUES ('Marka2-ModelC', (SELECT Id FROM Markalar Where Ad='Marka2'))");
                                                                                                                             
            migrationBuilder.Sql("INSERT INTO Modeller (Ad, MarkaId) VALUES ('Marka3-ModelA', (SELECT Id FROM Markalar Where Ad='Marka3'))");
            migrationBuilder.Sql("INSERT INTO Modeller (Ad, MarkaId) VALUES ('Marka3-ModelB', (SELECT Id FROM Markalar Where Ad='Marka3'))");
            migrationBuilder.Sql("INSERT INTO Modeller (Ad, MarkaId) VALUES ('Marka3-ModelC', (SELECT Id FROM Markalar Where Ad='Marka3'))");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Markalar Where Ad in('Marka1','Marka2','Marka3')");

        }
    }
}
