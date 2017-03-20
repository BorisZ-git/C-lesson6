using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * 3. Подсчитайте количество студентов:
а) учащихся на 5 и 6 курсах;
б)*подсчитайте сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся;
в) отсортируйте список по возрасту студента
г) *отсортируйте список по курсу и возрасту студента
 * */

namespace HomeWork
{
    class Program
    {
        static void Main(string[] args)
        {
            Students st = new Students();
            for (int i = 0; i < st.students.Length; i++)
                Console.WriteLine($"student: {st.students[i]} = age = {st.age[i]}");
        }
    }
}
