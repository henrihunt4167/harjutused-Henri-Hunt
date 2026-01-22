using System.IO.MemoryMappedFiles;

namespace Meetodid1
{
    internal class Program
    {
        public static string ReadAnswer()
        {
            string sisend = "";
            while (sisend == "")
            {
                sisend = Console.ReadLine();
            }
            return sisend;
        }





        private static void Main(string[] args)
        {

            List<string> filmid = GetMovies();
            Console.WriteLine("Milline on sinu lemmikfilm");
            string lemmikfilm = ReadAnswer();
            DoesMovieExist(filmid, lemmikfilm);


            List<string> otsitavadFilmid = new List<string> { "Terminator", "Vanamehe film", "Kratt" };
            IdentifyMovies(filmid, otsitavadFilmid);
        }


        public static void IdentifyMovies(List<string> collection, List<string> filter)
        {
            string messages = "";
            foreach (var movie in collection)
            {
                int itemnr = 0;
                foreach (var filterItem in filter)
                {
                    if (itemnr == 0)
                    {
                        messages += "Ill be back. \n";
                    }
                    else if (itemnr == 1)
                    {
                        messages += "Šnikurs\n";
                    }
                    else if (itemnr == 2)
                    {
                        messages += "Vaata et ta sul tehisplära ajama ei hakka\n";
                    }
                    itemnr++;
                }
                Console.WriteLine(messages);
            }
        }







        public static List<string> DoYouLikeThiMovie(List<string> collection, string movieToAdd)
        {


            if (collection.Contains(movieToAdd) == false)
            {
                Console.WriteLine($"Kas sulle meeldi {movieToAdd}?");
                string vastus = ReadAnswer();
                if (vastus == "jah")
            {
                collection.Add(movieToAdd);
                Console.WriteLine("Lisasin filmi sulle");
            }
            else
            {
                Console.WriteLine("Aga miks? See on ju hea film?");
            }
            }
            

            return collection;
        }
        public static void DoesMovieExist(List<string> collection, string findThis)
        {
            bool itExists = false;
            foreach (var item in collection)
            {
                if (item == findThis)
                {
                    itExists = true;
                }
            }
            if (itExists == true)
            {
                Console.WriteLine("Näe mäletasid ikka!");
            }
            else
            {
                Console.WriteLine("a kus sinu lemmikfilm?");
            }
        }



        public static List<string> GetMovies()

        {
            Console.WriteLine("Mis on sinu lemmikfilmid, sisesta ükshaaval, kui sisestada ei taha\n sisesta \"ei ole\"");
            string sisestus = "";
            List<string> siinonFilmid = new List<string>();
            while (sisestus != "ei ole")
            {
                Console.WriteLine("Järgmine film: ");
                sisestus = Console.ReadLine();
                if (sisestus != "ei ole")
                {
                    siinonFilmid.Add(sisestus);
                }
            }




            return siinonFilmid;

        }

    }
}
