using System;
using System.IO;

namespace KaloHash
{
    public static class CreateISO
    {
        //write in 1MB blocks for performance
        public static readonly int BLOCK = 2048 * 500;
        public static string status = String.Empty;
        public static void Create(string disk)
        {
            status = "Accessing Drive.";

            disk = disk.Trim('\\');
            using (var reader = new BinaryReader(new DeviceStream(@"\\.\" + disk)))
            using (var writer = new BinaryWriter(new FileStream(@"disk.iso", FileMode.Create)))
            {
                var buffer = new byte[BLOCK];
                int count;
                int loopcount = 0;
                try
                {
                    while ((count = reader.Read(buffer, 0, BLOCK)) > 0)
                    {
                        writer.Write(buffer, 0, count);
                        status = loopcount + " MB read from disk.";
                        if (loopcount % 100 == 0)
                        {
                            writer.Flush();
                        }
                        loopcount++;
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                reader.Close();
                writer.Flush();
                writer.Close();
            }
        }
    }
}
