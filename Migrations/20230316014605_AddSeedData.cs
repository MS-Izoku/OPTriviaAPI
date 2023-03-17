using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace OPTriviaAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddSeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Trivias",
                columns: new[] { "Id", "Text" },
                values: new object[,]
                {
                    { -25, "According to both Whitebeard and Howard Hamlin, of Hamlin Hamlin & McGill, the One Piece, the One Piece is Real!" },
                    { -24, "Oda often puts unimportant or unnecessary information in SBS volumes released in Japan, Q and A format.  These often contain clues towards the main story in terms of things we haven't explored yet" },
                    { -23, "Please hire me" },
                    { -22, "Oda often forgets about certain plotlines, and has admitted to going to fan sites to show him what plotlines he hasn't gone through yet" },
                    { -21, "Buggy deserves every bit of praise he gets, and is very likely another mythical zoan" },
                    { -20, "It is very likely that Shanks was to give Ace the Gum Gum fruit based on his relation to Roger and a specific cover-page, where Ace looks like a certain important future character" },
                    { -19, "There is an amazing cover story featuring Enel on the Moon that has yet to be animated in any regard, giving context to Lunar Civilizations years before the introduction of Lunarians" },
                    { -18, "The Drums of Liberation have yet to be accurately shown in the Anime to date, as Oda writes it as 4 beats instead of the 3-beat Skypeia version." },
                    { -17, "Oda foreshadows future events years in advance, if you go back and reread chapters" },
                    { -16, "One Piece is an ode to childhood joy" },
                    { -15, "Luffy is based after old-timey rubber-hose cartoon characters" },
                    { -14, "If Luffy was born somewhere IRL, Oda claims it would be Brazil" },
                    { -13, "It's been over 800 years since I last heard them, the Drums of Liberation.  JOY BOY!" },
                    { -12, "A more direct translation of Gorusei means '5 elder planets', not '5 elder stars'" },
                    { -11, "The new Monster Trio post-Wano arc represents the Trinity of the Planes, which is also represented by the Ancient Weapons" },
                    { -10, "One Piece has mythological references from Norse, Greco-Roman, Japanese, and Hindu mythologies/religions" },
                    { -9, "There is no such thing as a Logia fruit (shameless self promotion, OPTreasureTree)" },
                    { -8, "Ace was not originally written to be Roger's son" },
                    { -7, "The in-universe book Brag Men was first seen at Ohara, before being brought up by Nami.  It is now an IRL One Piece themed Gym for working out." },
                    { -6, "The Library of Ohara had a number of books on culture, rather than just research material (see Brag Men)" },
                    { -5, "Klaubaterman are actually a real-life mythical creature, which are accurately represented in the OP universe" },
                    { -4, "Blackbeard is directly based on Davy Jones, both the real figure and the mythological one" },
                    { -3, "Oda is a madman" },
                    { -2, "Each member of the Straw Hat Crew is based after a mythological demon from various cultures" },
                    { -1, "Luffy is based on the Hindu god Hanuman" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -25);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -24);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -23);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -22);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -21);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -20);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -19);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -18);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -17);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -16);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -15);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -14);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -13);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -12);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -11);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -10);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -9);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -8);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -7);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -6);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -5);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -4);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -3);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -2);

            migrationBuilder.DeleteData(
                table: "Trivias",
                keyColumn: "Id",
                keyValue: -1);
        }
    }
}
