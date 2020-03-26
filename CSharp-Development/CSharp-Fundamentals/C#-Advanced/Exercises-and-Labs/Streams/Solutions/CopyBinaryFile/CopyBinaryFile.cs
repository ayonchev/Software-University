using System;
using System.IO;

namespace CopyBinaryFile
{
    class CopyBinaryFile
    {
        static void Main()
        {
            using (var source = new FileStream("../copyMe.png", FileMode.Open))
            {
                using (var destination = new FileStream("copied-image.png", FileMode.Create))
                {
                    byte[] buffer = new byte[source.Length];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);
                    }
                }
            }
        }
    }
}
