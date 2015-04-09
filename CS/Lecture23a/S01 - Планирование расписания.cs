using System;
using System.Linq;
using System.Collections.Generic;

namespace Slide01
{
    class Work
    {
        public double Start { get; set; }
        public double End { get; set; }
    }


    public class Program
    {
        static IEnumerable<Work> FindSchedule(List<Work> works)
        {
            var sortedWorks = works.OrderBy(z => z.End);
            var currentEnd = double.NegativeInfinity;
            foreach(var work in sortedWorks)
                if (work.Start >= currentEnd)
                {
                    currentEnd = work.End;
                    yield return work;
                }
        }
    }
}