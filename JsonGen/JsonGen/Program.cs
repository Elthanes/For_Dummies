using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace JsonGen
{
    public class Row
    {
        public DateTime Datum { get; set; }
        public String Name { get; set; }
        public String Vorname { get; set; }
        public String Handynummer { get; set; }
        public int Anzahl { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            String path = "D:/stuff/b.txt";
            /*
            List<Row> myrows = new List<Row>();
            Row arow = new Row();
            arow.Datum = new DateTime(2018, 3, 5);
            arow.Name = "Mittermeyer";
            arow.Vorname = "Arnold";
            arow.Handynummer = "012371312123";
            arow.Anzahl = 4;
            myrows.Add(arow);
            Row brow = new Row();
            brow.Datum = DateTime.Now;
            brow.Name = "Heydrich";
            brow.Vorname = "Reinhard";
            brow.Handynummer = "0987654321012";
            brow.Anzahl = 2;
            myrows.Add(brow);
            String series = JsonConvert.SerializeObject(myrows,Formatting.Indented);
            File.WriteAllText(path, @series);
            Console.WriteLine(series);
            */
            List<Row> b = JsonConvert.DeserializeObject<List<Row>>(File.ReadAllText(path));
            Console.WriteLine(b[1].Name);
            Console.WriteLine(b[0].Name);
            Console.WriteLine(b[1].Datum);
            Console.ReadKey();


        }
    }
}
