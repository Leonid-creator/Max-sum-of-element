
namespace MaxSumOfElement
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string filePath;
            if (args.Length > 0)
            {
                filePath = args[0];
            }
            else
            {
                Console.WriteLine("Enter path:");
                filePath = Console.ReadLine();
            }

            LineInfo myFile = new LineInfo(filePath);
            try
            {
                myFile.MaxSumLine();
            }
            catch (FileEmptyException)
            {
                Console.WriteLine("File is empty");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found");
            }
            catch (IOException)
            {
                Console.WriteLine("An I/O error occurred while reading a file");
            }
            myFile.ShortInfo();
            Console.ReadLine();
        }
    }
}