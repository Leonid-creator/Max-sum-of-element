
namespace MaxSumOfElement.Test.UnitTesting.NUnit
{
    public class Tests
    {
        public static IEnumerable<(string, decimal, List<int>, List<int>)> TestCases()
        {
            yield return
            (
                @"TestData\Int.txt",
                655,
                new List<int> { 7 },
                new List<int> { }
            );
            yield return
            (
                @"TestData\IntSeveralBroken.txt",
                297,
                new List<int> { 7 },
                new List<int> { 0, 2, 3, 8 }
            );
            yield return
            (
                @"TestData\IntAllBroken.txt",
                0,
                new List<int> { },
                new List<int> { 0, 1, 2, 3, 4, 5, 6, 7 }
            );
            yield return
            (
                @"TestData\IntEqualLines.txt",
                293,
                new List<int> { 0, 1, 2, 3, 4, 5 },
                new List<int> { }
            );
            yield return
            (
                @"TestData\IntNegative.txt",
                323,
                new List<int> { 9 },
                new List<int> { }
            );
            yield return
            (
                @"TestData\IntSeveralMax.txt",
                655,
                new List<int> { 1, 4, 7 },
                new List<int> { }
            );
            yield return
            (
                @"TestData\Dec.txt",
                399.47m,
                new List<int> { 4 },
                new List<int> { }
            );
            yield return
            (
                @"TestData\DecBroken.txt",
                399.47m,
                new List<int> { 4 },
                new List<int> { 0, 1, 2, 8, 9 }
            );
        }
        [TestCaseSource(nameof(TestCases))]
        public void MaxSumLine_Path_MaxLine((string path, decimal expMaxSum, List<int> expMaxLines, List<int> expBrokenLines) td)
        {
            LineInfo testFile = new LineInfo(td.path);
            testFile.MaxSumLine();

            Assert.AreEqual(td.expMaxSum, testFile.MaxSum);
            Assert.AreEqual(td.expMaxLines, testFile.MaxLines);
            Assert.AreEqual(td.expBrokenLines, testFile.BrokenLines);

        }
        [Test]
        public void MaxSumLine_Empty_EmptyException()
        {
            LineInfo testFile = new LineInfo(@"TestData\Empty.txt");
            Assert.Throws<FileEmptyException>(() => testFile.MaxSumLine());
        }
    }
}