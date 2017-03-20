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
            course = new int[students.Length];           
            for (int i =0;i< students.Length; i++)
            {
                students[i] = i + 1;
                age[i] = r.Next(18, 23);
                if (age[i] == 18) course[i] = 1;
                else if (age[i] == 19) course[i] = 2;
                else if (age[i] == 20) course[i] = 3;
                else if (age[i] == 21) course[i] = 4;
                else if (age[i] == 22) course[i] = 5;
                else if (age[i] == 23) course[i] = 6;
            }
        }
    }
}
