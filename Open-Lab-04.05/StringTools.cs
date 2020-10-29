using System;

namespace Open_Lab_04._05
{
    public class StringTools
    {
        public string Repeat(string orig, int n)
        {
            string r = "";
            for (int i = 0; i < orig.Length; i++)
            {
                for (int k = 0; k < n; k++)
                {
                    r = r + orig[i];
                }
            }
            return r;
        }
    }
}