using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Test
{
    [TestClass]
    public class ControllerTest
    {
        [TestMethod]
        public void IsTotalCreditHoursWithinRange_ShouldBeWithinRange_WHenTotalCreditHoursIsWithinRange()
        {
            Controller c = new Controller();
           var list  = new List<SchoolClass>();
            list.Add(new SchoolClass(null,null,3,null));
            list.Add(new SchoolClass(null,null,5,null));
            list.Add(new SchoolClass(null,null,3,null));
            list.Add(new SchoolClass(null,null,3,null));
           var b = c.IsTotalCreditHoursWithinRange(list, 12, 15);
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void IsTotalCreditHoursWithinRange_ShouldBeOOR_WhenTotalCreditHoursIsOOR()
        {
            Controller c = new Controller();
            var list = new List<SchoolClass>();
            list.Add(new SchoolClass(null, null, 3, null));
            list.Add(new SchoolClass(null, null, 7, null));
            list.Add(new SchoolClass(null, null, 3, null));
            list.Add(new SchoolClass(null, null, 3, null));
            var b = c.IsTotalCreditHoursWithinRange(list, 12, 15);
            Assert.IsFalse(b);
        }

        [TestMethod]
        public void IsTotalCreditHoursWithinRange_ShouldBeWithinRange_WhenTotalCreditHoursIsOnLowerBoundryRanges()
        {
            Controller c = new Controller();
            var list = new List<SchoolClass>();
            list.Add(new SchoolClass(null, null, 3, null));
            list.Add(new SchoolClass(null, null, 3, null));
            list.Add(new SchoolClass(null, null, 3, null));
            list.Add(new SchoolClass(null, null, 3, null));
            var b = c.IsTotalCreditHoursWithinRange(list, 12, 15);
            Assert.IsTrue(b);
        }
        [TestMethod]
        public void IsTotalCreditHoursWithinRange_ShouldBeWithinRange_WhenTotalCreditHoursIsOnUpperBoundryRanges()
        {
            Controller c = new Controller();
            var list = new List<SchoolClass>();
            list.Add(new SchoolClass(null, null, 3, null));
            list.Add(new SchoolClass(null, null, 6, null));
            list.Add(new SchoolClass(null, null, 3, null));
            list.Add(new SchoolClass(null, null, 3, null));
            var b = c.IsTotalCreditHoursWithinRange(list, 12, 15);
            Assert.IsTrue(b);
        }
    }
}
