using OverloadingOperations;

namespace TestOverloadingOperations
{
    [TestClass]
    public class UnitTest1
    {
        SquareMatrix TestMatrix1 = new SquareMatrix(new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } });
        SquareMatrix TestMatrix2 = new SquareMatrix(new int[3, 3] { { 0, 1, 2 }, { 3, 4, 5 }, { 6, 7, 8 } });

        [TestMethod]
        public void TestSum()
        {
            SquareMatrix expectedMatrix = new SquareMatrix(new int[3, 3] { { 0, 2, 4 }, { 6, 8, 10 }, { 12, 14, 16 } });
            SquareMatrix actualMatrix = TestMatrix1 + TestMatrix2;
            Assert.AreEqual(expectedMatrix, actualMatrix);
        }
        [TestMethod]
        public void TestProduct()
        {
            SquareMatrix expectedMatrix = new SquareMatrix(new int[3, 3] { { 15, 18, 21 }, { 42, 54, 66 }, { 69, 90, 111 } });
            SquareMatrix actualMatrix = TestMatrix1 * TestMatrix2;
            Assert.AreEqual(expectedMatrix, actualMatrix);
        }
        [TestMethod]
        public void TestIsNotGreater()
        {
            bool isGreater = TestMatrix1 > TestMatrix2;
            Assert.IsFalse(isGreater);
        }
        [TestMethod]
        public void TestIsNotLess()
        {
            bool isLess = TestMatrix1 < TestMatrix2;
            Assert.IsFalse(isLess);
        }
        [TestMethod]
        public void TestIsGreaterOrEqual()
        {
            bool isGreaterOrEqual = TestMatrix1 >= TestMatrix2;
            Assert.IsTrue(isGreaterOrEqual);
        }
        [TestMethod]
        public void TestIsLessOrEqual()
        {
            bool isLessOrEqual = TestMatrix1 <= TestMatrix2;
            Assert.IsTrue(isLessOrEqual);
        }
        [TestMethod]
        public void TestIsEqual()
        {
            bool isEqual = TestMatrix1 == TestMatrix2;
            Assert.IsTrue(isEqual);
        }
        [TestMethod]
        public void TestIsNotEqual()
        {
            bool isEqualNotEqual = TestMatrix1 != TestMatrix2;
            Assert.IsFalse(isEqualNotEqual);
        }
        [TestMethod]
        public void TestTypeConversion()
        {
            int[,] testMatrixToInt = (int[,])TestMatrix1;
            Assert.IsInstanceOfType(testMatrixToInt, typeof(int[,]));
        }
        [TestMethod]
        public void TestCalculateDeterminant()
        {
            int[,] testMatrixToInt = (int[,])TestMatrix1;
            Assert.AreEqual(TestMatrix1.CalculateDeterminant(testMatrixToInt), 0);
        }
        [TestMethod]
        public void TestGetSubMatrix()
        {
            int[,] expectedMatrix = new int[,] { { 0, 1 }, { 3, 4 } };
            int[,] actualMatrix = TestMatrix1.GetSubMatrix((int[,])TestMatrix1, 2, 2);
            CollectionAssert.AreEqual((expectedMatrix), (actualMatrix));
        }
        [TestMethod]
        public void TestInvertMatrix()
        {
            double[,] actualMatrix = TestMatrix1.InvertMatrix((int[,])TestMatrix1);
            Assert.IsNotNull(actualMatrix);
        }
        [TestMethod]
        public void TestGetAdjointMatrix()
        {
            int[,] expectedMatrix = new int[,] { { -3, 6, -3 }, { 6, -12, 6 }, { -3, 6, -3 } };
            int[,] actualMatrix = TestMatrix1.GetAdjointMatrix((int[,])TestMatrix1);
            CollectionAssert.AreEqual((expectedMatrix), (actualMatrix));
        }
        [TestMethod]
        public void TestTransposeMatrix()
        {
            int[,] expectedMatrix = new int[,] { { 0, 3, 6 }, { 1, 4, 7 }, { 2, 5, 8 } };
            int[,] actualMatrix = TestMatrix1.TransposeMatrix((int[,])TestMatrix1);
            CollectionAssert.AreEqual((expectedMatrix), (actualMatrix));
        }
        [TestMethod]
        public void TestToString()
        {
            string testMatrixToString = TestMatrix1.ToString();
            Assert.IsInstanceOfType(testMatrixToString, typeof(string));
        }
        [TestMethod]
        public void TestCompareTo()
        {
            Assert.AreEqual(TestMatrix2.CompareTo(TestMatrix1), "Матрицы равны");
        }
        [TestMethod]
        public void TestEquals()
        {
            bool areEqual = TestMatrix1.Equals(TestMatrix2);
            Assert.IsTrue(areEqual);
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