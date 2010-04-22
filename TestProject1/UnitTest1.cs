using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using FMath;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void FMath_T_Start_With_Value_Eval_To_Value()
        {
            Assert.AreEqual(5, FMath<int>.Start(5));
        }

        [TestMethod]
        public void FMath_T_Start_Add_With_Value_Is_Correct()
        {
            Assert.AreEqual(10, 5.Start().Add(5));
        }

        [TestMethod]
        public void FMath_T_Start_Subtract_With_Value_Is_Correct()
        {
            Assert.AreEqual(10, FMath<int>.Start(15).Subtract(5));
        }

        [TestMethod]
        public void FMath_T_Start_Add_Subtract_With_Value_Is_Correct()
        {
            Assert.AreEqual(10, FMath<int>.Start(15).Add(5).Subtract(10));
        }

        [TestMethod]
        public void FMath_T_Start_Multiply_Subtract_Add_Is_Correct()
        {
            Assert.AreEqual(26, FMath<int>.Start(5).Multiply(5).Subtract(5).Add(6));
        }

        [TestMethod]
        public void FMath_T_Start_Subtract_Multiply_Add_Is_Correct()
        {
            Assert.AreEqual(2, FMath<int>.Start(6).Subtract(1).Multiply(5).Subtract(5).Add(6));
        }


        [TestMethod]
        public void FMath_T_Add_Expression()
        {
            var exp = 7.Start().Add(5);

            Assert.AreEqual(18, 6.Start().Add(exp));
        }



        [TestMethod]
        public void FMath_Evaluate_Action_Extension()
        {
            var result = FMath<double>.Evaluate(x =>
                                             {
                                                 x.StartWith(5);
                                                 x.Add(5);
                                                 x.Subtract(20);
                                             });

            Assert.AreEqual(-10, result);
        }

        [TestMethod]
        public void FMath_Evaluate_Action_Extension_With_Mult()
        {
            var result = FMath<double>.Evaluate(x =>
            {
                x.StartWith(5);
                x.Add(5);
                x.Multiply(2);
                x.Subtract(20);
            });

            Assert.AreEqual(-5, result);
        }

        [TestMethod]
        public void FMath_Evaluate_Action_Extension_With_Exp()
        {
            var result = FMath<double>.Evaluate(x =>
            {
                x.StartWith(5.5);
                x.Add(5);
                x.Multiply(2);
                x.Subtract(20);
                x.Add(20.Start().Add(10));
            });

            Assert.AreEqual(25.5, result);
        }
    }
}
