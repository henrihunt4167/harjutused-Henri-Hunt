namespace meetoditetööHuntProov3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. ülesanne
            float arv1 = 4.0f;
            float arv2 = 5.0f;
            float arv3 = 6.0f;
            float arv4 = 7.0f;
            float arv5 = 8.0f;
            Tervitus();
            //2. ülesanne
            Console.WriteLine("Sisesta palun esimene arv.");
            arv1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta palun teine arv.");
            arv2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta palun kolmas arv.");
            arv3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta palun neljas arv");
            arv4 = float.Parse(Console.ReadLine());
            Console.WriteLine("Sisesta palun viies arv");
            arv5 = float.Parse(Console.ReadLine());
            List<float> arvud = new List<float> { arv1, arv2, arv3, arv4, arv5 };
            Arvutus(arvud);
            //3. ülesanne
            string nimi = "";
            Console.WriteLine("Mis on sinu nimi?");
            nimi = Console.ReadLine();
            nimepikkus(nimi);
            //4.ülesanne
            Console.WriteLine("Kui kaugele sa läksid?");
            int kaugus = 0;
            kaugus = int.Parse(Console.ReadLine());
            kaugused(kaugus);
        }
        static public void Tervitus()
        {
            Console.WriteLine("Tere kasutaja!");
            return;
        }
        static public float Arvutus(List<float> arvud)
        {
            float arv = 0.0f;
            foreach (float v in arvud)
            {
                float element = v;
                arv *= element;
            }
            Console.WriteLine($"Sinu arvud kokku on {arv}");
            return arv;
        }
        static public string nimepikkus(string nimi)
        {
            string pikkus = nimi.Length.ToString();
            Console.WriteLine($"Sinu nimel on {pikkus} tähti");
            return pikkus;
        }
        static public int kaugused(int kaugused)
        {
            if (kaugused > 1 && kaugused < 5)
            {
                Console.WriteLine("ainult poodi jõudsid");
            }
            else if (kaugused > 5 && kaugused < 10)
            {
                Console.WriteLine("üle linna kõndisid");
            }
            else if (kaugused > 10 && kaugused < 20)
            {
                Console.WriteLine("ebainimlikult kaugele jõudsid");
            }
            return kaugused;
        }
    }
}
