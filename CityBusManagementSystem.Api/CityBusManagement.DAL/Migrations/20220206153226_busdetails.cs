using Microsoft.EntityFrameworkCore.Migrations;

namespace CityBusManagement.DAL.Migrations
{
    public partial class busdetails : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_RouteDetails",
                table: "RouteDetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_busDetails",
                table: "busDetails");

            migrationBuilder.RenameTable(
                name: "RouteDetails",
                newName: "routedetails");

            migrationBuilder.RenameTable(
                name: "busDetails",
                newName: "busdetails");

            migrationBuilder.RenameColumn(
                name: "Source",
                table: "routedetails",
                newName: "source");

            migrationBuilder.RenameColumn(
                name: "Destination",
                table: "routedetails",
                newName: "destination");

            migrationBuilder.RenameColumn(
                name: "BusName",
                table: "busdetails",
                newName: "busName");

            migrationBuilder.RenameColumn(
                name: "BusNo",
                table: "busdetails",
                newName: "busNo");

            migrationBuilder.RenameColumn(
                name: "routeno",
                table: "busdetails",
                newName: "arrivalTime");

            migrationBuilder.AddColumn<int>(
                name: "busStopNo",
                table: "routedetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_routedetails",
                table: "routedetails",
                column: "routeNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_busdetails",
                table: "busdetails",
                column: "busNo");

            migrationBuilder.CreateTable(
                name: "busstop",
                columns: table => new
                {
                    busStopNo = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    stopName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    arrivalTime = table.Column<int>(type: "int", nullable: false),
                    depatureTime = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_busstop", x => x.busStopNo);
                });

            migrationBuilder.CreateTable(
                name: "trip",
                columns: table => new
                {
                    tripId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    tripCount = table.Column<int>(type: "int", nullable: false),
                    busDetailsbusNo = table.Column<int>(type: "int", nullable: true),
                    routeDetailsrouteNo = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_trip", x => x.tripId);
                    table.ForeignKey(
                        name: "FK_trip_busdetails_busDetailsbusNo",
                        column: x => x.busDetailsbusNo,
                        principalTable: "busdetails",
                        principalColumn: "busNo",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_trip_routedetails_routeDetailsrouteNo",
                        column: x => x.routeDetailsrouteNo,
                        principalTable: "routedetails",
                        principalColumn: "routeNo",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    empId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    empName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    empType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    tripDetailstripId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.empId);
                    table.ForeignKey(
                        name: "FK_employee_trip_tripDetailstripId",
                        column: x => x.tripDetailstripId,
                        principalTable: "trip",
                        principalColumn: "tripId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_routedetails_busStopNo",
                table: "routedetails",
                column: "busStopNo");

            migrationBuilder.CreateIndex(
                name: "IX_employee_tripDetailstripId",
                table: "employee",
                column: "tripDetailstripId");

            migrationBuilder.CreateIndex(
                name: "IX_trip_busDetailsbusNo",
                table: "trip",
                column: "busDetailsbusNo");

            migrationBuilder.CreateIndex(
                name: "IX_trip_routeDetailsrouteNo",
                table: "trip",
                column: "routeDetailsrouteNo");

            migrationBuilder.AddForeignKey(
                name: "FK_routedetails_busstop_busStopNo",
                table: "routedetails",
                column: "busStopNo",
                principalTable: "busstop",
                principalColumn: "busStopNo",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_routedetails_busstop_busStopNo",
                table: "routedetails");

            migrationBuilder.DropTable(
                name: "busstop");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "trip");

            migrationBuilder.DropPrimaryKey(
                name: "PK_routedetails",
                table: "routedetails");

            migrationBuilder.DropIndex(
                name: "IX_routedetails_busStopNo",
                table: "routedetails");

            migrationBuilder.DropPrimaryKey(
                name: "PK_busdetails",
                table: "busdetails");

            migrationBuilder.DropColumn(
                name: "busStopNo",
                table: "routedetails");

            migrationBuilder.RenameTable(
                name: "routedetails",
                newName: "RouteDetails");

            migrationBuilder.RenameTable(
                name: "busdetails",
                newName: "busDetails");

            migrationBuilder.RenameColumn(
                name: "source",
                table: "RouteDetails",
                newName: "Source");

            migrationBuilder.RenameColumn(
                name: "destination",
                table: "RouteDetails",
                newName: "Destination");

            migrationBuilder.RenameColumn(
                name: "busName",
                table: "busDetails",
                newName: "BusName");

            migrationBuilder.RenameColumn(
                name: "busNo",
                table: "busDetails",
                newName: "BusNo");

            migrationBuilder.RenameColumn(
                name: "arrivalTime",
                table: "busDetails",
                newName: "routeno");

            migrationBuilder.AddPrimaryKey(
                name: "PK_RouteDetails",
                table: "RouteDetails",
                column: "routeNo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_busDetails",
                table: "busDetails",
                column: "BusNo");
        }
    }
}
