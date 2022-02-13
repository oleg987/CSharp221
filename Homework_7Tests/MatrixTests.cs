using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework_7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_7.Tests
{
    [TestClass()]
    public class MatrixTests
    {
        [TestMethod()]
        public void MatrixTest()
        {
           // Assert.Fail();
        }

        [TestMethod()]
        public void MatrixTest1()
        {
            //Assert.Fail();
        }

        [TestMethod()]
        public void task_903Test()
        {
            //Arrange
            int[,] array = { { 0, 1, 2, }, { 3, 4, 5 }, { 6, 7, 8, } };
            var matrix = new Matrix(array);
            int expected_sum = 20;
            //Act
            int actual = matrix.task_903(array);
            //Assert
            Assert.AreEqual(expected_sum, actual);
        }

        [TestMethod()]
        public void task_904Test()
        {
            //Arrange
            int[,] array = { { 0, 1, 2, }, { 3, 4, 5 }, { 6, 7, 8, } };
            var matrix = new Matrix(array);
            int expected_max = 8;
            //Act
            int actual = matrix.task_904(array);
            //Assert
            Assert.AreEqual(expected_max, actual);
        }
    }
}