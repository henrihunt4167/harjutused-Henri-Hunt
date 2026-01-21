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

        



        static void Main(string[] args)
        
        {

            List<string> filmid = GetMovies();
            Console.WriteLine("Milline on sinu lemmikfilm");
            string lemmikfilm = ReadAnswer();
            DoesMovieExist(filmid, lemmikfilm);
        }
        
        public static List<string> DoYouLikeThiMovie(List<string> collection, string movieToAdd)
        {

        
            if (Collection.Contains(movieToAdd) == false)
            {
                Console.WriteLine($"Kas sulle meeldi {movieToAdd}?");
                string vastus = ReadAnswer();
            }
            if (vastus == "jah")
            {
                collection.Add(movieToAdd);
                Console.WriteLine("Lisasin filmi sulle");
            }
            else
            {
                Console.WriteLine("Aga miks? See on ju hea film?");
            }

                return collection;
        }
        public static void DoesMovieExist(List<string> collection, string findThis)
        {
            bool itExists = false;
            foreach  (var item in collection)
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
