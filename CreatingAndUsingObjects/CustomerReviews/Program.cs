using System;

namespace CustomerReviews
{
    class Program
    {
        static Random rnd = new Random();
        static void Main(string[] args)
        {
            //11. Your're given arrays of strings representing customers experience + information about them
            //Generate a sentence from those phrases (phraces have to be chosen randomly)

            string[] gratidudePhrases =
            {
                "This product is excelent!",
                "This is an amazing product!",
                "I'm always using this product!",
                "This is the best prodcut of its type!"
            };

            string[] experiencePhrases =
            {
                "Now I feel much better!",
                "My transformation was successful!",
                "I can't believe it but now I feel better!",
                "I am a different person now!"
            };

            string[] authorsFirstName =
            {
                "Diana",
                "Petya",
                "Elena",
                "Katya"
            };

            string[] authorsLastName =
            {
                "Ivanova",
                "Petrova",
                "Milenova",
                "Kirova"
            };

            string[] cities =
            {
                "Sofia",
                "Plovdiv",
                "Varna",
                "Burgas",
                "Ruse"
            };


            string sentence = GenerateSentence(gratidudePhrases, experiencePhrases, authorsFirstName,
                authorsLastName, cities);

            Console.WriteLine(sentence);

        }

        public static string GenerateSentence(string[] gratPhr, string[] expPhr, string[] fNames, string[] lNames, string[] cities)
        {
            string gratitudePhrace = gratPhr[rnd.Next(0, 3)];
            string experiencePhrase = expPhr[rnd.Next(0, 3)];
            string authorFirstName = fNames[rnd.Next(0, 3)];
            string authorLastName = lNames[rnd.Next(0, 3)];
            string city = cities[rnd.Next(0, 4)];

            string senctence = gratitudePhrace + ". " + experiencePhrase + ". - "
                + authorFirstName + " " + authorLastName + ", " + city;

            return senctence;
        }
    }
}
