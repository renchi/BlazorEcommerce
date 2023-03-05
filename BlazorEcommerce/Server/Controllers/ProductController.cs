using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private static List<Product> Products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Title = "Pokémon Adventures: Diamond and Pearl/Platinum, Vol. 1",
                Description = "All your favorite Pokémon game characters jump out of the screen into the pages of this action-packed manga!\r\n\r\nPokémon Trainers Pearl and Diamond are starstruck! Their lifelong dream is to floor an audience with their Pokémon comedy act. So how do they wind up as bodyguards to a pampered little rich girl on a quest to reach the peak of Mt. Coronet...?!\r\n\r\nCome along and join the thrills and laughs as Pokémon Adventures continues!",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1348801940i/9215459.jpg",
                Price = 9.99m
            },
            new Product
            {
                Id = 2,
                Title = "Magical Pokemon Journey, Volume 1: A Party with Pikachu",
                Description = "In Journey I, which includes volumes 1-4 of the epic, Hazel has a crush on Almond, a Pokemon trainer. Her grandfather promises to make a love potion that will turn Almond's head -- but only if she will search the world for Pokemon for him first Hazel and friends first visit a Jigglypuff. It can sing, but can it cook? Next, it's a Pokemon holiday with loads of presents. Will Squirtle be a good host? What will Almond give Hazel? When they all visit the beach, Hazel vanishes in the water to help a Horsea. Who will tell Almond and Pikachu that she's safe?",
                ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1180211620i/1011118.jpg",
                Price = 7.99m
            },
            new Product
            {
                Id = 3,
                Title = "Harry Potter and the Philosopher’s Stone",
                Description = "Harry Potter thinks he is an ordinary boy - until he is rescued by an owl, taken to Hogwarts School of Witchcraft and Wizardry, learns to play Quidditch and does battle in a deadly duel. The Reason ... HARRY POTTER IS A WIZARD!",
                ImageUrl = "https://m.media-amazon.com/images/I/51Ppi-8kISL.jpg",
                Price = 6.99m
            }
        };

        [HttpGet]
        public async Task<ActionResult<List<Product>>> GetProduct()
        {
            return Ok(Products);
        }
    }
}
