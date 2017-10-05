using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Test
{
    [TestClass]
    public class TimeTest
    {
        [TestMethod]
        public void OverlapOfTwoTimesWillReturnTrueForOverlapsWithMethod()
        {
            string s = "1:30";
            string s2 = "5:30";

            string s3 = "3:30";
            string s4 = "6:30";
            var t = new Time(s, s2);
            var t2 = new Time(s3, s4);

            Assert.IsTrue(t.OverlapsWith(t2));
        }

        [TestMethod]
        public void NotOverlapOfTwoTimesWillReturnFalseForOverlapsMethod()
        {
            string s = "0:30";
            string s2 = "6:05";

            string s3 = "6:06";
            string s4 = "7:30";
            var t = new Time(s, s2);
            var t2 = new Time(s3, s4);

            Assert.IsFalse(t.OverlapsWith(t2));
        }

        [TestMethod]
        public void TimeWithStartTimeSameAsAnotherTimesEndTimeShouldReturnTrueForOverlap()
        {
            string s = "0:30";
            string s2 = "6:06";

            string s3 = "6:06";
            string s4 = "7:30";
            var t = new Time(s, s2);
            var t2 = new Time(s3, s4);

            var overlapsWith = t.OverlapsWith(t2);

            Assert.IsTrue(overlapsWith);
        }
    }
}
