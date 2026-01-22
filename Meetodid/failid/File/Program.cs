using System.Numerics;

internal class Program
{
    private static void Main(string[] args)
    {
        //Console.WriteLine("Kirjuta siia oma postikasti aadress");


        //string filePath = "C:\\Users\\opilane\\Source\\Repos\\harjutused Henri Hunt\\Meetodid\\failid\\File\\postkastiaadress.txt";
        //string aadress = Console.ReadLine();

        //File.WriteAllText(filePath, aadress);

        Console.WriteLine("Kõik laulusõnad");

        DisplayThisFile();

        FindWord("Denial");
    }
    public static void FindWord(string findThisWord)
    {
        using (StreamReader readFile = new StreamReader(
            "C:\\Users\\opilane\\Source\\Repos\\harjutused Henri Hunt\\Meetodid\\failid\\File\\jjjj.txt") )
        {
            int lnr = 0;
            while (readFile.EndOfStream == false)
            {
                string line = readFile.ReadLine();
                lnr++;

                if (line.Contains(findThisWord) == true)
                {
                    Console.WriteLine(findThisWord + " leiti reast " + lnr);
                }
            }
            readFile.Close();
        }
    }


    private static void DisplayThisFile()
    {
        string line = "";
        try
        {
            using (
                StreamReader readThisThing = new StreamReader
            ("C:\\Users\\opilane\\Source\\Repos\\harjutused Henri Hunt\\Meetodid\\failid\\File\\jjjj.txt") )
            {
                int LineCount = 0;
                while (readThisThing.EndOfStream == false)
                {
                    LineCount++;
                    line = readThisThing.ReadLine();
                    int pikkus = line.Length;
                    Console.WriteLine(LineCount + " " + line + " . Reapikkus on" + pikkus);
                }
                readThisThing.Close();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Ei saa lugeda sest:" + e.Message);
            throw;
        }
    }

}