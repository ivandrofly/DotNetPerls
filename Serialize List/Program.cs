using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

// [Note: You can paste the Lizard class here] <--
[Serializable()]
public class Lizard
{
    public string Type { get; set; }     // String property for Lizard object
    public int Number { get; set; }      // Number of lizards
    public bool Healthy { get; set; }    // Whether lizard is healthy

    public Lizard(string t, int n, bool h)
    {
        Type = t;
        Number = n;
        Healthy = h;
    }
}

internal class Program
{
    private static void Main()
    {
        Boolean quit = true;
        while (quit)
        {
            Console.WriteLine("s=serialize, r=read, q=quit:");
            switch (Console.ReadLine())
            {
                case "s":
                    var lizards1 = new List<Lizard>();
                    lizards1.Add(new Lizard("Thorny devil", 1, true));
                    lizards1.Add(new Lizard("Casquehead lizard", 0, false));
                    lizards1.Add(new Lizard("Green iguana", 4, true));
                    lizards1.Add(new Lizard("Blotched blue-tongue lizard", 0, false));
                    lizards1.Add(new Lizard("Gila monster", 1, false));

                    try
                    {
                        using (Stream stream = File.Open("data.bin", FileMode.Create))
                        {
                            BinaryFormatter bin = new BinaryFormatter();
                            bin.Serialize(stream, lizards1);
                        }
                    }
                    catch (IOException)
                    {
                    }
                    break;

                case "r":
                    try
                    {
                        using (Stream stream = File.Open("data.bin", FileMode.Open))
                        {
                            BinaryFormatter bin = new BinaryFormatter();

                            var lizards2 = (List<Lizard>)bin.Deserialize(stream);
                            foreach (Lizard lizard in lizards2)
                            {
                                Console.WriteLine("{0}, {1}, {2}",
                                    lizard.Type,
                                    lizard.Number,
                                    lizard.Healthy);
                            }
                        }
                    }
                    catch (IOException)
                    {
                    }
                    break;
                case "q":
                    quit = false;
                    break;
            }
        }
    }
}

//Output

//s=serialize, r=read:
//s
//s=serialize, r=read:
//r
//Thorny devil, 1, True
//Casquehead lizard, 0, False
//Green iguana, 4, True
//Blotched blue-tongue lizard, 0, False
//Gila monster, 1, False
//s=serialize, r=read: