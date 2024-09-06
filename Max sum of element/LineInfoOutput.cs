
namespace MaxSumOfElement
{
    public static class LineInfoOutput
    {
        public static void FieldsInfo(this LineInfo file)
        {
            Console.WriteLine($"File path: {file.FilePath}");
            Console.WriteLine($"Line counter: {file.LineCounter}");
            Console.WriteLine($"Max sum: {file.MaxSum}");
            Console.Write("MaxLines: ");
            foreach (int i in file.MaxLines)
            {
                Console.Write($"{i} ");
            }
            Console.Write("\nBrokenLines: ");
            foreach (int j in file.BrokenLines)
            {
                Console.Write($"{j} ");
            }
            Console.WriteLine();
        }

        public static void ShortInfo(this LineInfo file)
        {
            if (file.LineCounter == 0)
            {
                Console.WriteLine("No info");
            }
            else if (file.BrokenLines.Count == file.LineCounter && file.LineCounter > 0)
            {
                Console.WriteLine("All lines is broken");
            }
            else if (file.MaxLines.Count == file.LineCounter)
            {
                Console.WriteLine("All lines are equal");
                Console.WriteLine($"Sum of element = {file.MaxSum}");
            }
            else
            {
                Console.WriteLine($"Max sum = {file.MaxSum}");
                Console.Write($"Max lines index: ");
                foreach (int m in file.MaxLines)
                {
                    Console.Write($"{m} ");
                }
                if (file.BrokenLines.Count > 0)
                {
                    Console.Write("\nBroken lines: ");
                    foreach (int b in file.BrokenLines)
                    {
                        Console.Write($"{b} ");
                    }
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine();
                }
            }
        }
    }
}
