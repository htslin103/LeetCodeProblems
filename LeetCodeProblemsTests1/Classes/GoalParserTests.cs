using Microsoft.VisualStudio.TestTools.UnitTesting;
using LeetCodeProblems.Classes;
using System;
using System.Collections.Generic;
using System.Text;

namespace LeetCodeProblems.Classes.Tests
{
    [TestClass]
    public class GoalParserTests
    {
        [TestMethod]
        public void Interpret_method_provides_correct_parsed_result()
        {
            //Arrange
            string submittedString = "(al)(al)GG()()G(al)";
            string expectedResult = "alalGGooGal";
            
            //Act
            string returnedString = GoalParser.Interpret(submittedString);
            
            //Assert
            Assert.AreEqual(expectedResult, returnedString);
        }
    }
}