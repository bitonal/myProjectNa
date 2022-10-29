using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Ass1
{
    class Program
    {
    static void Main(string[] args)
        {
            // Read files 
            FileStream stream = null;
            string fileName = "C:/Users/Dell/myProjectNawal/DataStudent.txt";
            try
            {
                stream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
                StreamReader r = new StreamReader(stream);
                string text = r.ReadToEnd();
                Console.WriteLine(text);
                r.Close();
                stream.Close();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
            }
            Console.ReadLine();
        }
    }
}
