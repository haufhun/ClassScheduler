using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Controller
    {
        private List<SchoolClass> _classes;

        public Controller()
        {
            _classes = new List<SchoolClass>();
        }

        public void AddNewClass(string className, string teacher, int credits, Dictionary<DayOfWeek, List<Time>> classOptions)
        {
            var c = new SchoolClass(className, teacher, credits, classOptions);
            _classes.Add(c);
        }

        public bool IsTotalCreditHoursWithinRange(IEnumerable<SchoolClass> c, int min, int max)
        {
            var total = c.Sum(u => u.Credits);
            return Enumerable.Range(min, max+1 - min).Contains(total);
        }
    }
}
