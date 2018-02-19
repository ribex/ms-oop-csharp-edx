using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module3TutorialLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader streamReaderObject = null;

            try
            {
                streamReaderObject = new StreamReader("file1.txt");

                String contents = streamReaderObject.ReadToEnd();


                Console.WriteLine("The file has {0} text elements.", new StringInfo(contents).LengthInTextElements);
            }

            catch (FileNotFoundException)
            {
                Console.WriteLine("The file cannot be found.");
            }

            finally
            {
                if (streamReaderObject != null)
                {
                    streamReaderObject.Close();

                    streamReaderObject.Dispose();
                }
            }
        }
    }
}
