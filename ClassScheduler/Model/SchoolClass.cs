using System;
using System.Collections.Generic;

namespace Model
{
    public class SchoolClass
    {
        public int Credits { get; }

        public string ClassName { get; }

        public string Teacher { get;}

        private Dictionary<DayOfWeek, List<Time>> _classOptions;

        public SchoolClass()
        {
            
        }

        public SchoolClass(string t)
        {
            Teacher = t;
        }

        public SchoolClass(string className, string teacher, int credits, Dictionary<DayOfWeek, List<Time>> classOptions)
        {
            _classOptions = classOptions;
            ClassName = className;
            Teacher = teacher;
            Credits = credits;
        }

        public List<Time> GetTimesOnDay(DayOfWeek day)
        {
            throw new NotImplementedException();
        }


    }
}
