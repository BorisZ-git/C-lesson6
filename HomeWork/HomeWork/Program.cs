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
        static List<Students> db;
        static void Main(string[] args)
        {
            db = new List<Students>();
            FullList();
            Console.WriteLine(db[1].Age);
            Console.WriteLine(db[1].Course);
        }
        static void FullList()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                db.Add(new Students()
                {
                    Student = $" Student : {i + 1}",
                    Age = r.Next(18, 23),                    
                });
                db[i].Course = FullCourse(db[i]);
            }
        }
        static int FullCourse(Students db)
        {
            int count = 0;
            if (db.Age == 18) count = 1;
            else if (db.Age == 19) count = 2;
            else if (db.Age == 20) count = 3;
            else if (db.Age == 21) count = 4;
            else if (db.Age == 22) count = 5;
            else if (db.Age == 23) count = 6;
            return count;
        }

    }
    }

