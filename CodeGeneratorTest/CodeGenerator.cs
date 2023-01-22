using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeGenerator;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CodeGeneratorTest
{
   
    [TestClass]
    public class CodeGenerator
    {
        [TestMethod]
        public void GenerateCode_ShouldReturn8DigitUniqueCode()
        {
            var code = CodeProcess.GenerateCode();
            Assert.AreEqual(8, code.Length);
            Assert.IsTrue(code.Distinct().Count() == 8);
        }

        [TestMethod]
        public void GenerateWrongCode_ShouldReturn8DigitNotUniqueCode()
        {
            var code = CodeProcess.GenerateWrongCode();
            Assert.AreEqual(8, code.Length);
            Assert.IsFalse(code.Distinct().Count() == 8);
        }

        [TestMethod]
        public void CheckCode_ShouldReturnTrueForValidCodes()
        {
            var validCode = CodeProcess.GenerateCode();
            Assert.IsTrue(CodeProcess.CheckCode(validCode));
        }

        [TestMethod]
        public void CheckCode_ShouldReturnFalseForInvalidCodes()
        {
            var invalidCode = CodeProcess.GenerateWrongCode();
            Assert.IsFalse(CodeProcess.CheckCode(invalidCode));
        }
    }

}
