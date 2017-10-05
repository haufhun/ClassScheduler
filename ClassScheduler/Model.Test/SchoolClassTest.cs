using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Test
{

    [TestClass]
    public class SchoolClassTest
    {
        private const string t = "Dr. Gruenbacher";

        [TestMethod]
        public void SchoolClassEmptyConstructorContainsObjectIsNotNull()
        {
            var c = new SchoolClass();
            Assert.IsNotNull(c);
        }

        [TestMethod]
        public void SchoolClassConstructedWithTeacherContainsTeacher()
        {
            var c = new SchoolClass(t);
            Assert.AreEqual(t,c.Teacher);
        }

        [TestMethod]
        public void SchoolClassContainsOneClassTime()
        {
            const string ct = "MWF 11:30 12:20";
            
        }

        [TestMethod]
        public void SchoolClassContainsTwoClassTimes()
        {
            var d = new List<DayOfWeek> {DayOfWeek.Monday, DayOfWeek.Friday, DayOfWeek.Wednesday, DayOfWeek.Sunday};

            foreach (var i in d)
            {
                Console.WriteLine(i);
            }
            d.Sort();
            foreach (var i in d)
            {
                Console.WriteLine(i);
            }
        }
    }
}
