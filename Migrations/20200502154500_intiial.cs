using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CatMicroservice.Migrations
{
    public partial class intiial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    ID = table.Column<Guid>(nullable: false),
                    TagID = table.Column<string>(nullable: true),
                    Vaccination = table.Column<bool>(nullable: false),
                    DateOfLastVac = table.Column<DateTime>(nullable: false),
                    MealType = table.Column<int>(nullable: false),
                    CatName = table.Column<string>(nullable: true),
                    CatLitter = table.Column<string>(nullable: true),
                    CatCharacter = table.Column<string>(nullable: true),
                    CatVetName = table.Column<string>(nullable: true),
                    CatVetAddress1 = table.Column<string>(nullable: true),
                    CatVetAddress2 = table.Column<string>(nullable: true),
                    CatVetPostCode = table.Column<string>(nullable: true),
                    CatVetCity = table.Column<string>(nullable: true),
                    CatVetPhoneNo = table.Column<string>(nullable: true),
                    CatMedicalCondition = table.Column<string>(nullable: true),
                    Customer = table.Column<Guid>(nullable: false),
                    ChekedIn = table.Column<bool>(nullable: true),
                    ChekedOut = table.Column<bool>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.ID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cats");
        }
    }
}
