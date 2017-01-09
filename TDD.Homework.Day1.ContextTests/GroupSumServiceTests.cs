using Microsoft.VisualStudio.TestTools.UnitTesting;
using TDD.Homework.Day1.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NSubstitute;
using FluentAssertions;

namespace TDD.Homework.Day1.Context.Tests
{
    [TestClass()]
    public class GroupSumServiceTests
    {
        [TestMethod()]
        public void 測試_3筆一組_取Cost總和()
        {
            //arrange
            var target = new GroupSumService(new HomeworkDao());
            var groupCount = 3;
            var groupColumn = "cost";
            var expected = new List<int>() { 6, 15, 24, 21 };

            //act
            var actual = target.GetSummary(groupCount, groupColumn);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 測試_4筆一組_取Revenue總和()
        {
            //arrange
            var target = new GroupSumService(new HomeworkDao());
            var groupCount = 4;
            var groupColumn = "revenue";
            var expected = new List<int>() { 50, 66, 60 };

            //act
            var actual = target.GetSummary(groupCount, groupColumn);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 測試_2筆一組_取SellPrice總和()
        {
            //arrange
            var target = new GroupSumService(new HomeworkDao());
            var groupCount = 9;
            var groupColumn = "sellPrice";
            var expected = new List<int>() { 225, 61 };

            //act
            var actual = target.GetSummary(groupCount, groupColumn);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void 測試_2筆一組_取SellPrice總和_使用自訂類別()
        {
            //arrange
            var target = new GroupSumService(new ExtraDao());
            var groupCount = 9;
            var groupColumn = "col3";
            var expected = new List<int>() { 225, 61 };

            //act
            var actual = target.GetSummary(groupCount, groupColumn);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [ExpectedException(typeof(NullReferenceException))]
        [TestMethod()]

        public void 測試Expection_2筆一組_取SellPrice總和_輸入不存在的欄位()
        {
            //arrange
            var target = new GroupSumService(new HomeworkDao());
            var groupCount = 9;
            var groupColumn = "dasfasdf";
            var expected = new List<int>() { 225, 61 };

            //act
            var actual = target.GetSummary(groupCount, groupColumn);

            //assert
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]

        public void 測試Expection_2筆一組_取SellPrice總和_輸入不存在的欄位_使用FluentAssertions()
        {
            //arrange
            var target = new GroupSumService(new HomeworkDao());
            var groupCount = 9;
            var groupColumn = "badasfda";
            var expected = new List<int>() { 225, 61 };

            Action act = () => target.GetSummary(groupCount, groupColumn);
            act.ShouldThrow<NullReferenceException>();
        }

    }
}