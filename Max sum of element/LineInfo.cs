
namespace MaxSumOfElement
{
    public class LineInfo
    {
        public string FilePath;
        public int LineCounter;
        public decimal MaxSum;
        public List<int> MaxLines = new List<int>();
        public List<int> BrokenLines = new List<int>();

        public LineInfo(string path)
        {
            FilePath = path;
        }

        public void MaxSumLine()
        {
            using (StreamReader reader = new StreamReader(FilePath))
            {
                string line = reader.ReadLine();
                if (line == null)
                {
                    throw new FileEmptyException();
                }
                else
                {
                    bool lineIsNotBroken;
                    decimal lineSum;

                    while (line != null)
                    {
                        lineIsNotBroken = true;
                        string[] numbersStr = line.Split(",");
                        decimal[] numbersDec = new decimal[numbersStr.Length];

                        for (int i = 0; i < numbersStr.Length; i++)
                        {
                            if (!decimal.TryParse(numbersStr[i], out numbersDec[i]))
                            {
                                lineIsNotBroken = false;
                                BrokenLines.Add(LineCounter);
                                break;
                            }
                        }

                        lineSum = numbersDec.Sum();
                        if (lineIsNotBroken)
                        {
                            if (lineSum > MaxSum)
                            {
                                MaxSum = lineSum;
                                MaxLines.Clear();
                                MaxLines.Add(LineCounter);
                            }
                            else if (lineSum == MaxSum)
                            {
                                MaxLines.Add(LineCounter);
                            }
                        }
                        line = reader.ReadLine();
                        LineCounter++;
                    }
                }
            }
        }
    }
}
