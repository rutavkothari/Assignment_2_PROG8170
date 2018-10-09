using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Assignment_2;

namespace Assignment_2_Triangle_Test_Case
{
    [TestFixture]
    public class TriangleSolverTest
    {
        
        [Test]
        public void GetInput_Equilateral_Triangle()
        {
             //Arrange
             int TrinangleDimensionOne = 3;
             int TrinangleDimensionTwo = 3;
             int TrinangleDimensionThree = 3;
             string expectedResult = "This is an equilateral triangle";

             //Act
             string result = TriangleSolver.Analyze(TrinangleDimensionOne, TrinangleDimensionTwo, TrinangleDimensionThree);

            //Assert
             Assert.AreEqual(result, expectedResult); 
        }

        [Test]
        public void GetInput_Isosceles_Triangle()
        {
             //Arrange
             int TrinangleDimensionOne = 10;
             int TrinangleDimensionTwo = 10;
             int TrinangleDimensionThree = 5;
             string expectedResult = "This is an isosceles triangle";

            //Act
            string result = TriangleSolver.Analyze(TrinangleDimensionOne, TrinangleDimensionTwo, TrinangleDimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }


         [Test]
         public void GetInput_Scalene_Triangle()
         {
            //Arrange
            int TrinangleDimensionOne = 5;
            int TrinangleDimensionTwo = 4;
            int TrinangleDimensionThree = 6;
            string expectedResult = "This is scalene triangle";
            
            //Act
            string result = TriangleSolver.Analyze(TrinangleDimensionOne, TrinangleDimensionTwo, TrinangleDimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
 
         [Test]
         public void GetValue_Equilateral_Triangle()
         {
            //Arrange
            int TrinangleDimensionOne = 5;
            int TrinangleDimensionTwo = 5;
            int TrinangleDimensionThree = 5;
            string expectedResult = "This is an equilateral triangle";
            
            //Act
            string result = TriangleSolver.Analyze(TrinangleDimensionOne, TrinangleDimensionTwo, TrinangleDimensionThree);

            //Assert
            Assert.AreEqual(result, expectedResult);
          }
        
        [Test]
        public void GetValue_Scalene_Triangle()
        {
            //Arrange
            int TrinangleDimensionOne = 10;
            int TrinangleDimensionTwo = 11;
            int TrinangleDimensionThree = 12;
            string expectedResult = "This is scalene triangle";
            
            //Act
            string result = TriangleSolver.Analyze(TrinangleDimensionOne, TrinangleDimensionTwo, TrinangleDimensionThree);
            
            //Assert
            Assert.AreEqual(result, expectedResult); 
        }

        [Test]
        public void GetValue_isosceles_Triangle()
        {
            //Arrange
            int TrinangleDimensionOne = 11;
            int TrinangleDimensionTwo = 11;
            int TrinangleDimensionThree = 12;
            string expectedResult = "This is an isosceles triangle";
            
            //Act
            string result = TriangleSolver.Analyze(TrinangleDimensionOne, TrinangleDimensionTwo, TrinangleDimensionThree);
            
            //Assert
            Assert.AreEqual(result, expectedResult);
        }


        [Test]
        public void GetValue_scalene_Triangle()
        {
            //Arrange
            int TrinangleDimensionOne = 10;
            int TrinangleDimensionTwo = 12;
            int TrinangleDimensionThree = 13;
            string expectedResult = "This is scalene triangle";

            //Act
            string result = TriangleSolver.Analyze(TrinangleDimensionOne, TrinangleDimensionTwo, TrinangleDimensionThree);
            
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [Test]
        public void GetInputValue_Equilateral_Triangle()
        {
            //Arrange
            int TrinangleDimensionOne = 9;
            int TrinangleDimensionTwo = 9;
            int TrinangleDimensionThree =9;
            string expectedResult = "This is an equilateral triangle";
            //Act
            string result = TriangleSolver.Analyze(TrinangleDimensionOne, TrinangleDimensionTwo, TrinangleDimensionThree);
            //Assert
            Assert.AreEqual(result, expectedResult);
        }

    }
}
