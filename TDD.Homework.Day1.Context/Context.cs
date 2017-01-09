using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.Homework.Day1.Context
{
    public static class Context
    {
        internal static List<object> groupSum;

        static Context()
        {
        }
        internal static List<object> GetHomeworkData()
        {
            List<int> ids = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            List<int> costs = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            List<int> revenues = new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            List<int> sellPrices = new List<int>() { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            groupSum = new List<object>();
            ids.ForEach(d => groupSum.Add(new
            {
                id = d,
                cost = costs.ElementAt(ids.IndexOf(d)),
                revenue = revenues.ElementAt(ids.IndexOf(d)),
                sellPrice = sellPrices.ElementAt(ids.IndexOf(d))
            }));
            return groupSum;
        }
        internal static List<object> GetExtraData()
        {
            List<int> ids = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            List<int> col1s = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11 };
            List<int> col2s = new List<int>() { 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21 };
            List<int> col3s = new List<int>() { 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31 };
            groupSum = new List<object>();
            ids.ForEach(d => groupSum.Add(new
            {
                id = d,
                col1 = col1s.ElementAt(ids.IndexOf(d)),
                col2 = col2s.ElementAt(ids.IndexOf(d)),
                col3 = col3s.ElementAt(ids.IndexOf(d))
            }));
            return groupSum;
        }
    }
}

