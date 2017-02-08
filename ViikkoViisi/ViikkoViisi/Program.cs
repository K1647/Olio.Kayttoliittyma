using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViikkoViisi
{
    class Program
    {
        static void Main(string[] args)
        {
            //TestaaNimet();
            Tehtava2();
            //Tehtava3();
        }
        static void TestaaNimet()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            int kukkeli = 0;
            Console.Write("Anna nimien määrä > ");
            kukkeli = Convert.ToInt32(Console.ReadLine());
            string[] lines = new string[kukkeli];
            for (int i = 0; i < kukkeli; i++)
            {
                Console.Write("Anna nimi > ");
                lines[i] = Console.ReadLine();
            }
            System.IO.StreamWriter outputFile = null;
            try
            {
                outputFile = new System.IO.StreamWriter(mydocpath + @"\testi.txt");
                foreach (string line in lines)
                {
                    Console.WriteLine("");
                    outputFile.WriteLine(line);
                }
            }
            catch (Exception ex)
            {
                //Console.WriteLine("Some exception happened!");
                Console.WriteLine(ex.Message); // Access to the path 'c:\test.file' is denied.
            }
            finally
            {
                // check for null because OpenWrite might have failed
                if (outputFile != null)
                {
                    outputFile.Close();
                }
            }
            try
            {
                lines = System.IO.File.ReadAllLines(mydocpath + @"\testi.txt");
                Console.WriteLine("Nimet olivat:");
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
        }
        static void Tehtava2()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string filu = mydocpath + @"\nimet.txt";
            string temp = mydocpath + @"\temp.txt";
            Console.WriteLine(File.Exists(filu) ? "Nimet.txt exists." : "Nimet.txt does not exist.");
            try
            {
                string[] lines = System.IO.File.ReadAllLines(filu);
                int index = lines.Length;
                List<string> nimet = new List<string>(lines);
                List<string> noDupes = nimet.Distinct().ToList();
                foreach (string s in noDupes)
                {
                    Console.WriteLine(s);
                }
                var duplicates = nimet.GroupBy(x => x)
                .Where(g => g.Count() > 1)
                .ToDictionary(x => x.Key, y => y.Count());
                Console.WriteLine("Tiedostossa {0} riviä ja {1} nimeä\nNimet joita oli listassa useampi", index,noDupes.Count);
                foreach (var d in duplicates)
                {
                    Console.WriteLine(d);
                }
                System.IO.File.Copy(filu, temp, true);
                Console.WriteLine(File.Exists(temp) ? "Temp.txt exists." : "Temp.txt does not exist.");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found (FileNotFoundException)");
            }
            
        }
        static void Tehtava3()
        {
            string mydocpath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string intlist = mydocpath + @"\int.txt";
            string floatlist = mydocpath + @"\float.txt";
            try
            {
                List<float> fList = new List<float>();
                List<int> iList = new List<int>();
                string s;
                int i; float f;
                do
                {
                    Console.WriteLine("Give a number (enter or not a number ends) : ");
                    s = Console.ReadLine();
                    if (int.TryParse(s, out i))
                    {
                        iList.Add(i);
                    }
                    else if (float.TryParse(s, out f))
                    {
                        fList.Add(f);
                    }
                }
                while (int.TryParse(s, out i) || float.TryParse(s, out f));

                using (StreamWriter sw = new StreamWriter(intlist))
                {
                    foreach (int intti in iList)
                    {
                        sw.WriteLine(intti);
                    }
                }
                using (StreamWriter sw = new StreamWriter(floatlist))
                {
                    foreach (float kappa in fList)
                    {
                        sw.WriteLine(kappa);
                    }
                }
                Console.WriteLine("REAALILUVUT");
                string[] intline = System.IO.File.ReadAllLines(intlist);
                foreach (string line in intline)
                {
                    Console.WriteLine(line);
                }
                Console.WriteLine("KOKONAISLUVUT");
                string[] floatline = System.IO.File.ReadAllLines(floatlist);
                foreach (string line2 in floatline)
                {
                    Console.WriteLine(line2);
                }
            }
            catch (Exception e)
            {

                throw e;
            }
        }
    }

}
