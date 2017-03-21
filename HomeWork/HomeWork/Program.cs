using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/* Boris Z
 * 3. Подсчитайте количество студентов:
а) учащихся на 5 и 6 курсах;
b)*подсчитайте сколько студентов в возрасте от 18 до 20 лет на каком курсе учатся;
c) отсортируйте список по возрасту студента
d) *отсортируйте список по курсу и возрасту студента
 * */

namespace HomeWork
{
    class Program
    {
        static List<Students> db;
        static void Main(string[] args)
        {
            db = new List<Students>();
            Students.FullList(db);            
            #region a
            int a = 0;
            foreach (var e in db)
            {
                if (e.Course == 5 || e.Course == 6)
                    a++;
            }
            Console.WriteLine(a);
            #endregion
            #region b
            int course1 = 0;
            int course2 = 0;
            int course3 = 0;

            foreach (var e in db)
            {
                if (e.Age == 18) course1++;
                if (e.Age == 19) course2++;
                if (e.Age == 20) course3++;
            }
            Console.WriteLine($"Первокуры: {course1}\nФторы: {course2}\nТретий:{course3}");
            #endregion
            #region c
            db.Sort(Students.StudentsCompareAge);
            foreach (var e in db)
                Console.WriteLine($"{e.Age}  ");
            #endregion
            #region d
            //Для большей наглядности сортировки поменяем значение
            for (int i = 0; i < 50; i++)
                db[i].Course = 3;
            //Создаем отсортированый список
            var sortDB = Students.StCom(db);
            foreach (var e in sortDB)
                Console.WriteLine($"{e.Student}: age - {e.Age}; course - {e.Course}");
            #endregion

        }
    }
    }

