using static System.Runtime.InteropServices.JavaScript.JSType;
using System.ComponentModel;
using System.Runtime.Intrinsics.X86;
using System.IO;

namespace Assignment_2_3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Assignment 2.3.1
             * 
             * Write a console application to create a text file and save your basic details like 
             * name, age, address ( use dummy data). Read the details from same file and print on console.
             */

            // Create/write to a text file
            string filePath = "textFileDemo.txt";
            string text = "Maximus,Prime,99,Brooklyn NY";

            WriteFile(filePath, text);

            // Read the text file
            ReadFile(filePath);

        }

        static public void WriteFile(string FilePath, string Text)
        {
            try
            {
                // Using will close the sw once it is done
                using (StreamWriter sw = new(FilePath))
                {
                    sw.WriteLine(Text);
                }

                Console.WriteLine($"File created successfully at {FilePath}");
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }

        }

        static public void ReadFile(string FilePath)
        {
            string line;
            try
            {
                using (StreamReader sr = new(FilePath))
                {
                    line = sr.ReadLine();

                    while (line != null)
                    {
                        Console.WriteLine(line);

                        // Read the next line
                        line = sr.ReadLine();
                    }
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e.Message}");
            }
        }
    }
}
