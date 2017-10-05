using System;

namespace Model
{
    public class SchoolClass
    {
        public string Teacher { get; }

        public string ClassTime { get; }

        public SchoolClass()
        {
        }

        public SchoolClass(string t)
        {
            Teacher = t;
        }

        public SchoolClass(string t, string ct)
        {
            Teacher = t;
            ClassTime = ct;
        }
    }
}
