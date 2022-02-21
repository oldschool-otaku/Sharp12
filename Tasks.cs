using System;
using System.IO;
using System.Linq;
using System.Text;

namespace Sharp12
{
    public static class Tasks
    {
        public static string Reverse(string originalString) => new string(originalString.Reverse().ToArray());
        public static bool IsFormattableImplemented(object param) => param is IFormattable;
        public static bool AsFormattableImplemented(object param) => param is IFormattable;
        
        //TODO: переписать это говно
        public static void BadCode(string inputFileName)
        {

            if (File.Exists(inputFileName))
            {
                if (inputFileName != null)
                {
                    File.WriteAllText("C:/Users/ArtSt/RiderProjects/Sharp12/ResultText.txt",
                        File.ReadAllText(inputFileName, Encoding.UTF8).ToUpper(),
                        Encoding.UTF8);
                    
                }

                Console.WriteLine("Result has been saved in file ResultText");
            }
            else
            {
                Console.WriteLine("File \"{0}\" does not exist!", inputFileName);
            }
        }
    }
}