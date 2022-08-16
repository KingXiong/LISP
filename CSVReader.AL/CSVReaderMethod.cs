using System;
using System.IO;
using CSVReader.BL;

public class CSVReaderMethod
{
    public static void Main()
    {
        try
        {
            // Create an instance of StreamReader to read from a file.
            // The using statement also closes the StreamReader.
            string filePath = "/Github/repos/LISP/CSVReader_Examples.csv";
            List<Recruit> Recruits = new List<Recruit>();

            StreamReader sr = new StreamReader(filePath);
            
            
            List<string> lines = File.ReadAllLines(filePath).ToList();

            foreach (var l in lines)
            {
                //Inserting values into string array. Split at ','.
                string[] insert = l.Split(',');

                var recruit = new Recruit();

                recruit.UserID = insert[0];
                recruit.FirstName = insert[1];
                recruit.LastName = insert[2];
                recruit.Insurance = insert[4];

                int recruitVersion = 0;
                if (Int32.TryParse(insert[3], out recruitVersion))
                {
                    recruit.Version = int.Parse(insert[3]);

                }

                Recruits.Add((Recruit)recruit);

            }
            //Sorting the contents of each file by last and first name in ascending order.
            foreach (var r in Recruits.OrderBy(x => x.UserID).ThenBy(x =>x.Version))
            {
                Console.WriteLine($"{r.UserID}: {r.FirstName} {r.LastName} {r.Version} {r.Insurance}");
            }
            Console.ReadLine();

        }
        catch (Exception e)
        {
            // Let the user know what went wrong.
            Console.WriteLine("The file could not be read:");
            Console.WriteLine(e.Message);
        } 
    }
}