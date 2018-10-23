
using System;
using System.IO;

class Program
{
    static void Main()
    {
        // Read all bytes in from a file on the disk.
        //byte[] file = File.ReadAllBytes("C:\\ICON1.png");
        byte[] file = File.ReadAllBytes(@"D:\ExrcseFiles_Java.zip");

        // Create a memory stream from those bytes.
        using (MemoryStream memory = new MemoryStream(file))
        {
            // Use the memory stream in a binary reader.
            using (BinaryReader reader = new BinaryReader(memory))
            {
                // Read in each byte from memory.
                for (int i = 0; i < file.Length; i++)
                {
                    byte result = reader.ReadByte();
                    Console.WriteLine(result);
                }
            }
        }
    }
}

//Output
//    (The bytes from the file are written.)

//137
//80
//78
//71
//13
//10
//26
//10
//0
//0
//0
//13
//73
//72...