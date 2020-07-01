using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using System;
using System.Collections.Generic;

namespace CvNetCore2.Migrations
{
    public partial class Initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserDetails",
                columns: table => new
                {
                    UserDetailsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Dateofbirth = table.Column<DateTime>(nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Mobile = table.Column<string>(nullable: true),
                    Name = table.Column<string>(nullable: true),
                    Position = table.Column<string>(nullable: true),
                    Surname = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserDetails", x => x.UserDetailsID);
                });

            migrationBuilder.CreateTable(
                name: "Abouts",
                columns: table => new
                {
                    AboutID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    AboutText = table.Column<string>(nullable: true),
                    UserDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Abouts", x => x.AboutID);
                    table.ForeignKey(
                        name: "FK_Abouts_UserDetails_UserDetailsID",
                        column: x => x.UserDetailsID,
                        principalTable: "UserDetails",
                        principalColumn: "UserDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Courses",
                columns: table => new
                {
                    CoursesID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    CoursesDescription = table.Column<string>(nullable: true),
                    CoursesName = table.Column<string>(nullable: true),
                    EndDate = table.Column<string>(nullable: true),
                    StartDate = table.Column<string>(nullable: true),
                    UserDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Courses", x => x.CoursesID);
                    table.ForeignKey(
                        name: "FK_Courses_UserDetails_UserDetailsID",
                        column: x => x.UserDetailsID,
                        principalTable: "UserDetails",
                        principalColumn: "UserDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    HobbyID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    HobbyText = table.Column<string>(nullable: true),
                    UserDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.HobbyID);
                    table.ForeignKey(
                        name: "FK_Hobbies_UserDetails_UserDetailsID",
                        column: x => x.UserDetailsID,
                        principalTable: "UserDetails",
                        principalColumn: "UserDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    LanguageID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    LanguageDescription = table.Column<string>(nullable: true),
                    LanguageLevel = table.Column<int>(nullable: false),
                    LanguageName = table.Column<string>(nullable: true),
                    UserDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.LanguageID);
                    table.ForeignKey(
                        name: "FK_Languages_UserDetails_UserDetailsID",
                        column: x => x.UserDetailsID,
                        principalTable: "UserDetails",
                        principalColumn: "UserDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Skills",
                columns: table => new
                {
                    SkillsID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    SkillDescription = table.Column<string>(nullable: true),
                    SkillLevel = table.Column<int>(nullable: false),
                    SkillName = table.Column<string>(nullable: true),
                    UserDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Skills", x => x.SkillsID);
                    table.ForeignKey(
                        name: "FK_Skills_UserDetails_UserDetailsID",
                        column: x => x.UserDetailsID,
                        principalTable: "UserDetails",
                        principalColumn: "UserDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserAdress",
                columns: table => new
                {
                    UserAdressID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    City = table.Column<string>(nullable: false),
                    Line1 = table.Column<string>(nullable: false),
                    Line2 = table.Column<string>(nullable: true),
                    Line3 = table.Column<string>(nullable: true),
                    Postcode = table.Column<string>(nullable: false),
                    UserDetailsID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAdress", x => x.UserAdressID);
                    table.ForeignKey(
                        name: "FK_UserAdress_UserDetails_UserDetailsID",
                        column: x => x.UserDetailsID,
                        principalTable: "UserDetails",
                        principalColumn: "UserDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Works",
                columns: table => new
                {
                    WorkID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    UserDetailsID = table.Column<int>(nullable: true),
                    WorkEndDate = table.Column<DateTime>(nullable: false),
                    WorkName = table.Column<string>(nullable: true),
                    WorkPosition = table.Column<string>(nullable: true),
                    WorkStartDate = table.Column<DateTime>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Works", x => x.WorkID);
                    table.ForeignKey(
                        name: "FK_Works_UserDetails_UserDetailsID",
                        column: x => x.UserDetailsID,
                        principalTable: "UserDetails",
                        principalColumn: "UserDetailsID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "WorkDescription",
                columns: table => new
                {
                    WorkDescriptionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    WorkDescriptionText = table.Column<string>(nullable: true),
                    WorkID = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WorkDescription", x => x.WorkDescriptionID);
                    table.ForeignKey(
                        name: "FK_WorkDescription_Works_WorkID",
                        column: x => x.WorkID,
                        principalTable: "Works",
                        principalColumn: "WorkID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Abouts_UserDetailsID",
                table: "Abouts",
                column: "UserDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Courses_UserDetailsID",
                table: "Courses",
                column: "UserDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Hobbies_UserDetailsID",
                table: "Hobbies",
                column: "UserDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Languages_UserDetailsID",
                table: "Languages",
                column: "UserDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_Skills_UserDetailsID",
                table: "Skills",
                column: "UserDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_UserAdress_UserDetailsID",
                table: "UserAdress",
                column: "UserDetailsID");

            migrationBuilder.CreateIndex(
                name: "IX_WorkDescription_WorkID",
                table: "WorkDescription",
                column: "WorkID");

            migrationBuilder.CreateIndex(
                name: "IX_Works_UserDetailsID",
                table: "Works",
                column: "UserDetailsID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Abouts");

            migrationBuilder.DropTable(
                name: "Courses");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropTable(
                name: "Skills");

            migrationBuilder.DropTable(
                name: "UserAdress");

            migrationBuilder.DropTable(
                name: "WorkDescription");

            migrationBuilder.DropTable(
                name: "Works");

            migrationBuilder.DropTable(
                name: "UserDetails");
        }
    }
}
