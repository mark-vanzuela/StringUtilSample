using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StringUtilNS;
using System.Collections.Generic;

namespace StringUtilTestNS
{
    [TestClass]
    public class StringUtilTest
    {
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IndexOf_SubLongerThanText_ShouldThrowException()
        {
            //arrange
            string text = "This is the main string";
            string subText = "this is the longer sub text";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);
            
            //assert
            //handled by exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IndexOf_TextIsNullOrEmpty_ShouldThrowArgumentException()
        {
            //arrange
            string text = "";
            string subText = "this is the longer sub text";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);

            //assert
            //handled by exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IndexOf_SubTextIsNullOrEmpty_ShouldThrowArgumentException()
        {
            //arrange
            string text = "This is the main string";
            string subText = "";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);

            //assert
            //handled by exception
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOf_IndexIsMoreThanTextLength_ShouldThrowIndexOutOfRangeException()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "Abc";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText, 100);

            //assert
            //handled by exception
        }

        [TestMethod]
        [ExpectedException(typeof(IndexOutOfRangeException))]
        public void IndexOf_IndexPlusSubTextLengthIsMoreThanTextLength_ShouldThrowIndexOutOfRangeException()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "Abc";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText, 92);

            //assert
            //handled by exception
        }

        [TestMethod]
        public void IndexOf_SubTextIsNotFound_ShouldReturnNegativeOne()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "Abc";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);

            //assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void IndexOf_SubTextFoundAtFirstCaseSensitive_ShouldReturnOne()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "Polly";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);

            //assert
            Assert.AreEqual(1, index);
        }

        [TestMethod]
        public void IndexOf_SubTextFoundAtFirstCaseInSensitive_ShouldReturnOne()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "polly";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);

            //assert
            Assert.AreEqual(1, index);
        }

        [TestMethod]
        public void IndexOf_SubTextFoundCaseSensitive_ShouldReturn90()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "tea";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);

            //assert
            Assert.AreEqual(90, index);
        }

        [TestMethod]
        public void IndexOf_SubTextFoundCaseInSensitive_ShouldReturn90()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "TEA";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);

            //assert
            Assert.AreEqual(90, index);
        }

        [TestMethod]
        public void IndexOf_MultipleSubTextFoundCaseSensitive_ShouldReturn1()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "Polly";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);

            //assert
            Assert.AreEqual(1, index);
        }

        [TestMethod]
        public void IndexOf_MultipleSubTextFoundCaseInSensitive_ShouldReturn1()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "POLLY";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText);

            //assert
            Assert.AreEqual(1, index);
        }

        [TestMethod]
        public void IndexOf_MultipleSubTextFoundStartAt50CaseSensitive_ShouldReturn51()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "Polly";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText, 50);

            //assert
            Assert.AreEqual(51, index);
        }

        [TestMethod]
        public void IndexOf_MultipleSubTextFoundStartAt50CaseInSensitive_ShouldReturn51()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "POLLY";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText, 50);

            //assert
            Assert.AreEqual(51, index);
        }

        [TestMethod]
        public void IndexOf_SubTextFoundCaseSensitiveWithOptionalParameterIndex_ShouldReturn90()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "tea";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText, 89);

            //assert
            Assert.AreEqual(90, index);
        }

        [TestMethod]
        public void IndexOf_SubTextFoundCaseInSensitiveWithOptionalParameterIndex_ShouldReturn90()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "tea";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText, 89);

            //assert
            Assert.AreEqual(90, index);
        }

        [TestMethod]
        public void IndexOf_SubTextNotFoundCaseSensitiveWithOptionalParameterIndex_ShouldReturnNeg1()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "Polly";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText, 80);

            //assert
            Assert.AreEqual(-1, index);
        }

        [TestMethod]
        public void IndexOf_SubTextNotFoundCaseInSensitiveWithOptionalParameterIndex_ShouldReturnNeg1()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "POLLY";
            var util = new StringUtil();

            //act
            var index = util.IndexOf(text, subText, 80);

            //assert
            Assert.AreEqual(-1, index);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void IndexesOf_SubLongerThanText_ShouldThrowException()
        {
            //arrange
            string text = "This is the main string";
            string subText = "this is the longer sub text";
            var util = new StringUtil();

            //act
            var index = util.IndexesOf(text, subText);

            //assert
            //handled by exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IndexesOf_TextIsNullOrEmpty_ShouldThrowArgumentException()
        {
            //arrange
            string text = "";
            string subText = "this is the longer sub text";
            var util = new StringUtil();

            //act
            var indexes = util.IndexesOf(text, subText);

            //assert
            //handled by exception
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void IndexesOf_SubTextIsNullOrEmpty_ShouldThrowArgumentException()
        {
            //arrange
            string text = "This is the main string";
            string subText = "";
            var util = new StringUtil();

            //act
            var indexes = util.IndexesOf(text, subText);

            //assert
            //handled by exception
        }

        [TestMethod]
        public void IndexesOf_SubTextNotFound_ShouldReturnBlankList()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "XXX";
            var util = new StringUtil();

            //act
            var indexes = util.IndexesOf(text, subText);

            //assert
            Assert.AreEqual(0, indexes.Count);
        }

        [TestMethod]
        public void IndexesOf_SubTextFound_ShouldReturn3Items()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "Polly";

            List<int> expectedIndexes = new List<int>();
            expectedIndexes.Add(1);
            expectedIndexes.Add(26);
            expectedIndexes.Add(51);

            var util = new StringUtil();

            //act
            var indexes = util.IndexesOf(text, subText);

            //assert
            CollectionAssert.AreEqual(expectedIndexes, indexes);
        }

        [TestMethod]
        public void IndexesOf_SubTextFoundCaseInsensitive_ShouldReturn3Items()
        {
            //arrange
            string text = "Polly put the kettle on, polly put the kettle on, polly put the kettle on we'll all have tea";
            string subText = "Polly";

            List<int> expectedIndexes = new List<int>();
            expectedIndexes.Add(1);
            expectedIndexes.Add(26);
            expectedIndexes.Add(51);

            var util = new StringUtil();

            //act
            var indexes = util.IndexesOf(text, subText);

            //assert
            CollectionAssert.AreEqual(expectedIndexes, indexes);
        }

        
    }
}
