using System;
using System.Collections.Generic;

namespace HackerRankPractice
{
    public class GradingStudent
    {
        public GradingStudent()
        {
            List<int> grades = new List<int>();
            grades.Add(84);     //85
            grades.Add(94);     //95
            grades.Add(21);     //21
            grades.Add(100);    //100
            grades.Add(62);     //62
            grades.Add(30);     //30
            grades.Add(61);     //61
            grades.Add(53);     //55
            List<int> retval = gradingStudents(grades);
        }
        public static List<int> gradingStudents(List<int> grades)
        {
            List<int> retVal = new List<int>();
            foreach (int grade in grades)
            {
                int x = 0;
                if (grade < 38) x = grade;
                else if (grade % 5 < 3) x = grade;
                else x = 5 * ((int)(grade/5)+1);

                Console.WriteLine(x);
                retVal.Add(x);
            }

            return retVal;

        }
    }
}
