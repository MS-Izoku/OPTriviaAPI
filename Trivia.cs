using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace OPTriviaAPI
{
    public class Trivia
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]   // creates an auto-incremented ID
        public int Id { get; set; }
        public string Text { get; set; } = string.Empty;

        public Trivia(string text)
        {
            Text = text;
        }

        public Trivia(string text , int id)
        {
            Text = text;
            Id = id;
        }

        /// <summary>
        /// My custom seeding method for the time being, since there is a mass of strings to be converted and this is an easier method to run/show
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public static Trivia[] GenerateFromStringArray(string[] arr)
        {
            List<Trivia> list = new List<Trivia>();
            int currentSeedId = -1;
            foreach(string item in arr)
            {
                list.Add(new Trivia(item , currentSeedId));
                --currentSeedId;    // since a non-zero int needs to point to this new Trivia piece, the normally auto-incremented id will be negative for seed data
            }
            return list.ToArray();
        }


    }
}
