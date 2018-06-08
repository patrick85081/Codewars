using System;

namespace Codewars
{
    public class Triangle
    {
        public static bool IsTriangle(int length1, int length2, int length3)
        {
            if (length1 <= 0 || length2 <= 0 || length3 <= 0)
                return false;

            return (length1 + length2) > length3 && 
                (Math.Abs(length1 - length2) < length3);
        }
    }
}