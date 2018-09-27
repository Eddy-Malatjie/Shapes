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
                Console.WriteLine();
                Console.WriteLine(FileName);
                Console.WriteLine("*****************************************************************************");
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
            DateTime SecondTime;
            double Duration;
            int LineNumber = 1;

            while ((Line = Stream.ReadLine()) != null)
            {
                SecondTime = DateTime.Parse(Line.Substring(11, 8));
                Duration = (SecondTime - FirstTime).TotalSeconds;
                LineNumber++;

                if(Duration > 5)
                {
                    Console.WriteLine("Line No [{0}] - {1} Seconds - {2} ",LineNumber,Duration,Line);
                }
                
                FirstTime = SecondTime;
            }
                Console.WriteLine("Done");
        }              
    }
}
