using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    public static class TriangleSolver
    {
        
        public static string Analyze(int TriangleDimensionOne, int TrinangleDimensionTwo, int TriangleDimensionThree)
        {
            string type = string.Empty;
            if (TriangleDimensionOne == TrinangleDimensionTwo && TrinangleDimensionTwo == TriangleDimensionThree)
            {
                type = "This is an equilateral triangle";
            }
            else if (TriangleDimensionOne == TrinangleDimensionTwo || TriangleDimensionOne == TriangleDimensionThree || TrinangleDimensionTwo == TriangleDimensionThree)
            {
                type = "This is an isosceles triangle";
            }
            else
            {
                type = "This is scalene triangle";
            }
            return type;
        }
    }
}
