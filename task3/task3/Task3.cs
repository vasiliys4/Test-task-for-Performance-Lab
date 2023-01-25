using Newtonsoft.Json;
using System.Text.Json;
using System.IO;
using System.Diagnostics.Metrics;

namespace task3
{
    internal class Task3
    {
        static void Main(string[] args)
        {            
            List<Value> list1 = new List<Value>();
            var File1 = Console.ReadLine();
            var File2 = Console.ReadLine();
            var json0 = "";
            var json1 = "";
            //string path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\tests.json";
            //string path2 = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\values.json";
            using (var fstream = new StreamReader(File1))
            {
                json0 = fstream.ReadToEnd();              
            }            
            var Ds = JsonConvert.DeserializeObject<Rootobject>(json0);
  
            using (var fstream = new StreamReader(File2))
            {
                json1 = fstream.ReadToEnd();
            }
            var Ds1 = JsonConvert.DeserializeObject<Rootobject2>(json1);

            for (int i = 0; i < Ds.tests.Length; i++)
            {
                
                    for (int j = 0; j < Ds1.values.Length; j++)
                    {
                    
                        if (Ds.tests[i].id == Ds1.values[j].id)
                        {
                            Ds.tests[i].value = Ds1.values[j].value;
                        }
                    if (Ds.tests[i].values is not null)
                    {
                        for (int q = 0; q < Ds.tests[i].values.Length; q++)
                        {
                            if (Ds.tests[i].values[q].id == Ds1.values[j].id)
                            {
                                Ds.tests[i].values[q].value = Ds1.values[j].value;
                            }
                            if (Ds.tests[i].values[q].values is not null)
                            {
                                for (int w = 0; w < Ds.tests[i].values[q].values.Length; w++)
                                {
                                    //if (Ds.tests[i].values[q].values[w].id == Ds1.values[j].id)
                                    //{
                                    //    Ds.tests[i].values[q].values[w].value = Ds1.values[j].value;
                                    //}
                                    if (Ds.tests[i].values[q].values[w].values is not null)
                                    {
                                        for (int e = 0; e < Ds.tests[i].values[q].values[w].values.Length; e++)
                                        {
                                            if (Ds.tests[i].values[q].values[w].values[e].id == Ds1.values[j].id)
                                            {
                                                Ds.tests[i].values[q].values[w].values[e].value = Ds1.values[j].value;
                                            }
                                        }
                                    }
                                }
                            }
                        }

                    }
                }                                   
            }
            var options = new JsonSerializerOptions
            {
                WriteIndented = true
            };
            string json = System.Text.Json.JsonSerializer.Serialize(Ds, options);
            File.WriteAllText(@"C:\Users\sente\OneDrive\Рабочий стол\report.json", json);
        }
    }
}