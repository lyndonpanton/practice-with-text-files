namespace Exercise2
{
    using System.IO;
    using System.Collections.Generic;
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialise the file stream
            StreamReader fileInput = null;
            StreamWriter fileOutput = null;

            try
            {
                // open the file
                fileInput = File.OpenText("practice_with_text_files.txt");


                fileOutput = File.CreateText("even_more_practice_with_text_files.txt");

                // read the first line
                string line = fileInput.ReadLine();

                int i = 1;

                // loop while more lines remain
                while (line != null)
                {
                    // output the current line
                    Console.WriteLine(line);

                    if (i % 2 == 0)
                    {
                        fileOutput.WriteLine(line);
                    }

                    // get the next line
                    line = fileInput.ReadLine();

                    i++;
                }
            }
            catch (Exception exception)
            {
                // catch error if one occurred
                Console.WriteLine("An error occurred");
            }
            finally
            {
                // if there is nothing left to be read
                if (fileInput != null)
                {
                    // close the  file
                    fileInput.Close();
                    fileOutput.Close();
                }
            }

            // initialise the file stream
            //StreamWriter fileOutput = null;

            //try
            //{
            //    // create the file
            //    fileOutput = File.CreateText("more_practice_with_text_files.txt");

            //    // write the first line of the file
            //    fileOutput.WriteLine("This is a text file");

            //    // write the second line of the file, etc.
            //    fileOutput.WriteLine("This text file was created on: 19/02/2023");
            //    fileOutput.WriteLine("This text file contains characters");
            //    fileOutput.WriteLine();
            //    fileOutput.WriteLine("This text file was created using the C# StreamWriter class");
            //    fileOutput.WriteLine("This text file was created by Lyndon Panton");
            //} catch (Exception exception)
            //{
            //    // catch error if one occurred
            //    Console.WriteLine("An error occurred");
            //} finally
            //{
            //    // if there is nothing left to be written
            //    if (fileOutput != null)
            //    {
            //        // close the file
            //        fileOutput.Close();
            //    }
            //}
        }
    }
}