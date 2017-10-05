using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Model.Test
{

    [TestClass]
    public class SchoolClassTest
    {
        [TestMethod]
        public void SchoolClassIsNotNull()
        {
            var c = new SchoolClass();
            Assert.IsNotNull(c);
        }
    }
}
