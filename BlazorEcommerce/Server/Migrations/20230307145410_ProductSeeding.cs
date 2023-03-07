using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorEcommerce.Server.Migrations
{
    /// <inheritdoc />
    public partial class ProductSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 1, "All your favorite Pokémon game characters jump out of the screen into the pages of this action-packed manga!\r\n\r\nPokémon Trainers Pearl and Diamond are starstruck! Their lifelong dream is to floor an audience with their Pokémon comedy act. So how do they wind up as bodyguards to a pampered little rich girl on a quest to reach the peak of Mt. Coronet...?!\r\n\r\nCome along and join the thrills and laughs as Pokémon Adventures continues!", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1348801940i/9215459.jpg", 9.99m, "Pokémon Adventures: Diamond and Pearl/Platinum, Vol. 1" },
                    { 2, "In Journey I, which includes volumes 1-4 of the epic, Hazel has a crush on Almond, a Pokemon trainer. Her grandfather promises to make a love potion that will turn Almond's head -- but only if she will search the world for Pokemon for him first Hazel and friends first visit a Jigglypuff. It can sing, but can it cook? Next, it's a Pokemon holiday with loads of presents. Will Squirtle be a good host? What will Almond give Hazel? When they all visit the beach, Hazel vanishes in the water to help a Horsea. Who will tell Almond and Pikachu that she's safe?", "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1180211620i/1011118.jpg", 7.99m, "Magical Pokemon Journey, Volume 1: A Party with Pikachu" },
                    { 3, "Harry Potter thinks he is an ordinary boy - until he is rescued by an owl, taken to Hogwarts School of Witchcraft and Wizardry, learns to play Quidditch and does battle in a deadly duel. The Reason ... HARRY POTTER IS A WIZARD!", "https://m.media-amazon.com/images/I/51Ppi-8kISL.jpg", 6.99m, "Harry Potter and the Philosopher’s Stone" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
