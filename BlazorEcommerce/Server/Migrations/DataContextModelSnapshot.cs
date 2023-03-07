﻿// <auto-generated />
using BlazorEcommerce.Server.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorEcommerce.Server.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorEcommerce.Shared.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImageUrl")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "All your favorite Pokémon game characters jump out of the screen into the pages of this action-packed manga!\r\n\r\nPokémon Trainers Pearl and Diamond are starstruck! Their lifelong dream is to floor an audience with their Pokémon comedy act. So how do they wind up as bodyguards to a pampered little rich girl on a quest to reach the peak of Mt. Coronet...?!\r\n\r\nCome along and join the thrills and laughs as Pokémon Adventures continues!",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1348801940i/9215459.jpg",
                            Price = 9.99m,
                            Title = "Pokémon Adventures: Diamond and Pearl/Platinum, Vol. 1"
                        },
                        new
                        {
                            Id = 2,
                            Description = "In Journey I, which includes volumes 1-4 of the epic, Hazel has a crush on Almond, a Pokemon trainer. Her grandfather promises to make a love potion that will turn Almond's head -- but only if she will search the world for Pokemon for him first Hazel and friends first visit a Jigglypuff. It can sing, but can it cook? Next, it's a Pokemon holiday with loads of presents. Will Squirtle be a good host? What will Almond give Hazel? When they all visit the beach, Hazel vanishes in the water to help a Horsea. Who will tell Almond and Pikachu that she's safe?",
                            ImageUrl = "https://images-na.ssl-images-amazon.com/images/S/compressed.photo.goodreads.com/books/1180211620i/1011118.jpg",
                            Price = 7.99m,
                            Title = "Magical Pokemon Journey, Volume 1: A Party with Pikachu"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Harry Potter thinks he is an ordinary boy - until he is rescued by an owl, taken to Hogwarts School of Witchcraft and Wizardry, learns to play Quidditch and does battle in a deadly duel. The Reason ... HARRY POTTER IS A WIZARD!",
                            ImageUrl = "https://m.media-amazon.com/images/I/51Ppi-8kISL.jpg",
                            Price = 6.99m,
                            Title = "Harry Potter and the Philosopher’s Stone"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
