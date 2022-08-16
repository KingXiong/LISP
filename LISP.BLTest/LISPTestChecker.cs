using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using LISP.BL;

namespace LISP.BLTest
{
    [TestClass]
    public class LISPTestChecker
    {

        [TestMethod]
        public void Matching_Input()
        {
            //Check for matching cases where there are equal amounts of parenthesis. 
            #region Arrange
            string input = "()";
            #endregion            

            #region Act
            bool output = LISP.BL.Checker.LISPInput(input);
            #endregion

            #region Assert
            Assert.AreEqual(true, output);
            #endregion
        }

        [TestMethod]
        public void Unmatched_Input()
        {
            //Check for matching cases where there are unequal amounts of parenthesis. 
            string input = "())";

            bool output = LISP.BL.Checker.LISPInput(input);
            Assert.AreEqual(false, output);
        }

        [TestMethod]
        public void Matching_Input_With_Strings()
        {
            string input = "(write ( + (/ 1 2)))";

            bool output = LISP.BL.Checker.LISPInput(input);

            Assert.AreEqual(true, output);
        }

        [TestMethod]
        public void Unmatched_Input_With_Strings()
        {
            string input = "(write  + (/ 1 2) (/ 3 4)))";

            bool output = LISP.BL.Checker.LISPInput(input);

            Assert.AreEqual(false, output);
        }
    }
}
