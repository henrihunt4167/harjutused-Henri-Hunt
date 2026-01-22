namespace failmeetod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
              
             Programm küsib kasutajalt reahaaval luuletuse ridu, küsitatakse 4 korda ja kontrollitakse kas kasutaja on sisestanud keelatud sõnu, keelatud sõnu ise asuvad loendis, kui kasutaja on sisestanud keelatud sõnu, küsitakse kogu ride kasutajalt uuesti.
            kui küsimine on lõppenud, küsitakse kasutajalt failinime, ja salvestatakse faili
            pärast salvestust kuvatakse kasutajale tagasi
             */
            Console.WriteLine("Sisesta oma luuletus, salvesta see fail, ja vaata oma luuletus hiljem üle");
            int riduOlemas = 0;
            string olemasolevSisu = "";
            while (riduOlemas < 4)
            {
                Console.WriteLine("Luuletuse järgmise rea sisestuseks kirjuta midagi.");
                List<string> keelatudSõnad = new List<string>() { "henrierik", "Skassu", "Juudiraha", "daanielHeidmets" };
                string hetkesisestus = "";
                while (hetkesisestus == "")
                {
                    hetkesisestus = readAnswer();
                    foreach (var ks in keelatudSõnad)
                    {
                        if (hetkesisestus.Contains(ks))
                        {
                            hetkesisestus = "";
                            Console.WriteLine("On leitud keelatud sõna, sisestus on tühistatud.");
                        }
                    }
                }
                olemasolevSisu += readAnswer();
            }
            Console.WriteLine("Sisesta failinimi, kuhu soovid oma luuletuse salvestada: ");
            string failinimi = readAnswer();
            string filepath = "C:\\Users\\opilane\\Source\\Repos\\harjutused Henri Hunt\\Meetodid\\failid\\failmeetod\\" + failinimi + ".txt";
            File.WriteAllText(filepath, olemasolevSisu);
            DisPlayLuuletus(filepath);

        }

        public static void DisPlayLuuletus(string location)
        {
          using (StreamReader readluuletus = new StreamReader(location))
            {
                while (readluuletus.EndOfStream == false)
                {
                    Console.WriteLine(readluuletus.ReadLine());
                }
                readluuletus.Close();
            }
        }

        public static string readAnswer()
        {
            string vastus = "";
            while (vastus == "")
            {
                Console.WriteLine("Tee vastav sisestus: ");
                vastus = Console.ReadLine();
            }
           return vastus;
        }

    } 
}
