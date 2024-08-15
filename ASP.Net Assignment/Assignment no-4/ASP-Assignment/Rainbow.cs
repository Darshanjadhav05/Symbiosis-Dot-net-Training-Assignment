using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ASP_Assignment
{
    public class Rainbow : IEnumerable<string>
    {
        private string[] colors = { "Red", "Orange", "Yellow", "Green", "Blue", "Indigo", "Violet" };

        public IEnumerator<string> GetEnumerator()
        {
            for (int i = 0; i < colors.Length; i++)
            {
                yield return colors[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}