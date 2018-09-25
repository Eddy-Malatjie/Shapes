using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    class LogFileReader
    {
        private int _numFiles;
        public LogFileReader(int num)
        {
            _numFiles = num;
        }

        public void ReadFiles ()
        {
            string FileName;
            string path;

            for (int i = 1; i <= _numFiles; i++)
            {
                FileName = "spindle.log." + i;
                path = @"C:\Users\Reverside\Documents\Visual Studio 2015\Projects\Shapes\Shapes\log\" + FileName;

                try
                {
                ReadAFile(path);
                }
                catch(FileNotFoundException e)
                {
                   Console.WriteLine(e.Message);
                }
                catch(Exception)
                {
                    Console.WriteLine("Call an admin");
                }
                
            }
        }
        
        private void ReadAFile(string Path)
        {
            StreamReader Stream = new StreamReader(Path);
            string Line = Stream.ReadLine();
            DateTime FirstTime = DateTime.Parse(Line.Substring(11, 8));
            string SecondTime;
            double duration;

            while ((Line = Stream.ReadLine()) != null)
            {
                SecondTime = Line.Substring(11, 8);
                Console.WriteLine(FirstTime);
                Console.WriteLine("SPACE");
                Console.WriteLine(SecondTime);
              //  duration = SecondTime.Subtract(FirstTime).TotalSeconds;
              //  Console.WriteLine(duration);


                }
                Console.WriteLine("Done");
        }
            


        
    }
}
