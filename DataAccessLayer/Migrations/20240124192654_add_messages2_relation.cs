using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DataAccessLayer.Migrations
{
    public partial class add_messages2_relation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Message2s",
                columns: table => new
                {
                    MessageID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SenderID = table.Column<int>(type: "int", nullable: true),
                    ReceiveID = table.Column<int>(type: "int", nullable: true),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MessageDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MessageStatus = table.Column<bool>(type: "bit", nullable: false),
                    MessageID1 = table.Column<int>(type: "int", nullable: true),
                    MessageID2 = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Message2s", x => x.MessageID);
                    table.ForeignKey(
                        name: "FK_Message2s_Messages_MessageID1",
                        column: x => x.MessageID1,
                        principalTable: "Messages",
                        principalColumn: "MessageID");
                    table.ForeignKey(
                        name: "FK_Message2s_Messages_MessageID2",
                        column: x => x.MessageID2,
                        principalTable: "Messages",
                        principalColumn: "MessageID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_ReceiveID",
                        column: x => x.ReceiveID,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                    table.ForeignKey(
                        name: "FK_Message2s_Writers_SenderID",
                        column: x => x.SenderID,
                        principalTable: "Writers",
                        principalColumn: "WriterID");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_MessageID1",
                table: "Message2s",
                column: "MessageID1");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_MessageID2",
                table: "Message2s",
                column: "MessageID2");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_ReceiveID",
                table: "Message2s",
                column: "ReceiveID");

            migrationBuilder.CreateIndex(
                name: "IX_Message2s_SenderID",
                table: "Message2s",
                column: "SenderID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Message2s");
        }
    }
}
