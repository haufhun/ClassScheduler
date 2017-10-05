using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Time
    {
        private readonly string _startTime;

        private readonly string _endTime;

        public Time(string start, string end)
        {
            _startTime = start;
            _endTime = end;
        }

        public bool OverlapsWith(Time t)
        {
            int c = string.CompareOrdinal(_startTime, t._startTime);

            if (c == 0)
                return true;

            int c2 = c < 0 ? string.CompareOrdinal(this._endTime, t._startTime) : string.CompareOrdinal(t._endTime, this._startTime);

            return c2 >= 0;
        }
    }
}
