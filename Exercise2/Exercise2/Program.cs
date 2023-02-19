
namespace Exercise2
{
    using System.IO;
    internal class Program
    {
        static void Main(string[] args)
        {
            // initialise stream
            StreamReader fileInput = null;

            try
            {
                // open file
                fileInput = File.OpenText("practice_with_text_files.txt");

                // read first line
                string line = fileInput.ReadLine();

                // loop while more lines remain
                while (line != null)
                {
                    // output the current line
                    Console.WriteLine(line);
                    // get the next line
                    line = fileInput.ReadLine();
                }
            } catch (Exception exception)
            {
                Console.WriteLine("An error occured");
            } finally
            {
                // if there is nothing left to be read
                if (fileInput != null)
                {
                    // close the  file
                    fileInput.Close();
                }
            }
        }
    }
}