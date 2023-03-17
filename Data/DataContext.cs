using Microsoft.EntityFrameworkCore;

namespace OPTriviaAPI.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { 
        }

        public DbSet<Trivia> Trivias { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            string[] OPTrivia = new string[] {
                "Luffy is based on the Hindu god Hanuman",
                "Each member of the Straw Hat Crew is based after a mythological demon from various cultures",
                "Oda is a madman",
                "Blackbeard is directly based on Davy Jones, both the real figure and the mythological one",
                "Klaubaterman are actually a real-life mythical creature, which are accurately represented in the OP universe",
                "The Library of Ohara had a number of books on culture, rather than just research material (see Brag Men)",
                "The in-universe book Brag Men was first seen at Ohara, before being brought up by Nami.  It is now an IRL One Piece themed Gym for working out.",
                "Ace was not originally written to be Roger's son",
                "There is no such thing as a Logia fruit (shameless self promotion, OPTreasureTree)",
                "One Piece has mythological references from Norse, Greco-Roman, Japanese, and Hindu mythologies/religions",
                "The new Monster Trio post-Wano arc represents the Trinity of the Planes, which is also represented by the Ancient Weapons",
                "A more direct translation of Gorusei means '5 elder planets', not '5 elder stars'",
                "It's been over 800 years since I last heard them, the Drums of Liberation.  JOY BOY!",
                "If Luffy was born somewhere IRL, Oda claims it would be Brazil",
                "Luffy is based after old-timey rubber-hose cartoon characters",
                "One Piece is an ode to childhood joy",
                "Oda foreshadows future events years in advance, if you go back and reread chapters",
                "The Drums of Liberation have yet to be accurately shown in the Anime to date, as Oda writes it as 4 beats instead of the 3-beat Skypeia version.",
                "There is an amazing cover story featuring Enel on the Moon that has yet to be animated in any regard, giving context to Lunar Civilizations years before the introduction of Lunarians",
                "It is very likely that Shanks was to give Ace the Gum Gum fruit based on his relation to Roger and a specific cover-page, where Ace looks like a certain important future character",
                "Buggy deserves every bit of praise he gets, and is very likely another mythical zoan",
                "Oda often forgets about certain plotlines, and has admitted to going to fan sites to show him what plotlines he hasn't gone through yet",
                "Please hire me",
                "Oda often puts unimportant or unnecessary information in SBS volumes released in Japan, Q and A format.  These often contain clues towards the main story in terms of things we haven't explored yet",
                "According to both Whitebeard and Howard Hamlin, of Hamlin Hamlin & McGill, the One Piece, the One Piece is Real!"
            };

            Trivia[] generatedTrivia = Trivia.GenerateFromStringArray(OPTrivia);
            modelBuilder.Entity<Trivia>().HasData(generatedTrivia);
        }
    }
}
