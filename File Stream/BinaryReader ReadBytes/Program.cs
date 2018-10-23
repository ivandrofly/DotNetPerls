using System;
using System.IO;
using System.Text;

/* class BinaryRW
{
    static void Main()
    {
        const int arrayLength = 1000;

        // Create random data to write to the stream. 
        byte[] dataArray = new byte[arrayLength];
        new Random().NextBytes(dataArray);

        BinaryWriter binWriter = new BinaryWriter(new MemoryStream());

        // Write the data to the stream.
        Console.WriteLine("Writing the data.");
        binWriter.Write(dataArray);

        // Create the reader using the stream from the writer.
        BinaryReader binReader =
            new BinaryReader(binWriter.BaseStream);

        // Set Position to the beginning of the stream.
        binReader.BaseStream.Position = 0;

        // Read and verify the data. 
        byte[] verifyArray = binReader.ReadBytes(arrayLength);
        if (verifyArray.Length != arrayLength)
        {
            Console.WriteLine("Error writing the data.");
            return;
        }
        for (int i = 0; i < arrayLength; i++)
        {
            if (verifyArray[i] != dataArray[i])
            {
                Console.WriteLine("Error writing the data.");
                return;
            }
        }
        Console.WriteLine("The data was written and verified.");
    }

} */


public class DumpFileSample
{
    private static readonly int CHUNK_SIZE = 1024;
    public static void Main(String[] args)
    {
        args = new string[] { "D:\\Simon & Garfunkel - The Best.zip" };
        if ((args.Length == 0) || !File.Exists(args[0]))
        {
            Console.WriteLine("Please provide an existing file name.");
        }
        else
        {
            using (FileStream fs = new FileStream(args[0], FileMode.Open, FileAccess.Read))
            {
                using (BinaryReader br = new BinaryReader(fs, new ASCIIEncoding()))
                {
                    byte[] chunk;
                    //var buffer = br.ReadBytes((int)fs.Length); // t
                    chunk = br.ReadBytes(CHUNK_SIZE);
                    while (chunk.Length > 0)
                    {
                        DumpBytes(chunk, chunk.Length);
                        chunk = br.ReadBytes(CHUNK_SIZE);
                    }
                }
            }
        }
    }

    public static void DumpBytes(byte[] bdata, int len)
    {
        int i;
        int j = 0;
        char dchar;
        // 3 * 16 chars for hex display, 16 chars for text and 8 chars 
        // for the 'gutter' int the middle.
        StringBuilder dumptext = new StringBuilder("        ", 16 * 4 + 8);
        for (i = 0; i < len; i++)
        {
            dumptext.Insert(j * 3, String.Format("{0:X2} ", (int)bdata[i]));
            dchar = (char)bdata[i];
            //' replace 'non-printable' chars with a '.'. 
            if (Char.IsWhiteSpace(dchar) || Char.IsControl(dchar))
            {
                dchar = '.';
            }
            dumptext.Append(dchar);
            j++;
            if (j == 16)
            {
                Console.WriteLine(dumptext);
                dumptext.Length = 0;
                dumptext.Append("        ");
                j = 0;
            }
        }
        // display the remaining line 
        if (j > 0)
        {
            for (i = j; i < 16; i++)
            {
                dumptext.Insert(j * 3, "   ");
            }
            Console.WriteLine(dumptext);
        }
    }
}

// http://msdn.microsoft.com/en-us/library/vstudio/system.io.binaryreader.readbytes(v=vs.110).aspx