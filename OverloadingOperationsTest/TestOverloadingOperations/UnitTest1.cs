using OverloadingOperations;

namespace TestOverloadingOperations
{
    [TestClass]
    public class UnitTest1
    {
        SquareMatrix TestMatrix1 = new SquareMatrix(3);
        SquareMatrix TestMatrix2 = new SquareMatrix(4);

        [TestMethod]
        public void TestSum()
        {
            SquareMatrix TestResultMatrix = TestMatrix1 + TestMatrix2;
        }
        [TestMethod]
        public void TestProduct()
        {
            SquareMatrix TestResultMatrix = TestMatrix1 * TestMatrix2;
        }
        [TestMethod]
        public void TestIsNotGreater()
        {
            bool IsGreater = TestMatrix1 > TestMatrix2;
            Assert.IsFalse(IsGreater);
        }
        [TestMethod]
        public void TestIsNotLess()
        {
            bool IsLess = TestMatrix1 < TestMatrix2;
            Assert.IsFalse(IsLess);
        }
        [TestMethod]
        public void TestIsNotGreaterOrEqual()
        {
            bool IsGreaterOrEqual = TestMatrix1 >= TestMatrix2;
            Assert.IsFalse(IsGreaterOrEqual);
        }
        [TestMethod]
        public void TestIsNOtLessOrEqual()
        {
            bool IsLessOrEqual = TestMatrix1 <= TestMatrix2;
            Assert.IsFalse(IsLessOrEqual);
        }
        [TestMethod]
        public void TestIsNOtEqual()
        {
            bool IsEqual = TestMatrix1 == TestMatrix2;
            Assert.IsFalse(IsEqual);
        }
        [TestMethod]
        public void TestIsNotEqual()
        {
            bool IsEqualNotEqual = TestMatrix1 != TestMatrix2;
            Assert.IsTrue(IsEqualNotEqual);
        }
        [TestMethod]
        public void TestTypeConversion()
        {
            int[,] TestMatrixToInt = (int[,])TestMatrix1;
            Assert.IsInstanceOfType(TestMatrixToInt, typeof(int[,]));
        }
        [TestMethod]
        public void TestCalculateDeterminant()
        {
            int[,] TestMatrixToInt = (int[,])TestMatrix1;
            TestMatrix1.CalculateDeterminant(TestMatrixToInt);
        }
        [TestMethod]
        public void TestGetSubMatrix()
        {
            int[,] TestMatrixToInt = (int[,])TestMatrix1;
            TestMatrix1.GetSubMatrix(TestMatrixToInt, 3, 3);
        }
        [TestMethod]
        public void TestInvertMatrix()
        {
            int[,] TestMatrixToInt = (int[,])TestMatrix1;
            TestMatrix1.InvertMatrix(TestMatrixToInt);
        }
        [TestMethod]
        public void TestGetAdjointMatrix()
        {
            int[,] TestMatrixToInt = (int[,])TestMatrix1;
            TestMatrix1.GetAdjointMatrix(TestMatrixToInt);
        }
        [TestMethod]
        public void TestTransposeMatrix()
        {
            int[,] TestMatrixToInt = (int[,])TestMatrix1;
            TestMatrix1.GetAdjointMatrix(TestMatrixToInt);
        }
        [TestMethod]
        public void TestPrintMatrix()
        {
            TestMatrix1.PrintMatrix();
        }
        [TestMethod]
        public void TestPrintDeterminant()
        {
            TestMatrix1.PrintDeterminant();
        }
        [TestMethod]
        public void TestPrintInvertMatrix()
        {
            TestMatrix1.PrintInvertMatrix();
        }
        [TestMethod]
        public void TestPrintClone()
        {
            TestMatrix1.PrintMatrix();
        }
        [TestMethod]
        public void TestPrintHashCode()
        {
            TestMatrix1.PrintHashCode();
        }
        [TestMethod]
        public void TestToString()
        {
            string TestMatrixToString = TestMatrix1.ToString();
            Assert.IsInstanceOfType(TestMatrixToString, typeof(string));
        }
        [TestMethod]
        public void TestCompareTo()
        {
            Assert.AreEqual(TestMatrix2.CompareTo(TestMatrix1), -1);
        }
        [TestMethod]
        public void TestEquals()
        {
            bool result = TestMatrix1.Equals(TestMatrix2);
            Assert.IsInstanceOfType(result, typeof(bool));
        }
        [TestMethod]
        public void TestGetHashCode()
        {
            Assert.IsInstanceOfType(TestMatrix1.GetHashCode(), typeof(int));
        }
        [TestMethod]
        public void TestClone()
        {
            Assert.AreEqual(TestMatrix1.Clone(), TestMatrix1);
        }
    }
}