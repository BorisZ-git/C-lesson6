using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Students
    {
        public int[] students;
        public int[] age;
        int[] course;
        Random r = new Random();        
        public Students()
        {
            students = new int[100];
            age = new int[students.Length];
            course = new int[6] { 1, 2, 3, 4, 5, 6 };
            for (int i =0;i< students.Length; i++)
            {
                students[i] = i + 1;
                age[i] = r.Next(18, 23);
            }
        }
    }
}
