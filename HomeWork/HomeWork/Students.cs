using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    /// <summary>
    /// Класс содержащий инфо о студентах
    /// </summary>
    class Students
    {
        public string Student { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        /// <summary>
        /// Сортирует по возрасту и курсу
        /// </summary>
        /// <param name="db">передаваемый список, как аргумент</param>
        /// <returns>отсортированый список</returns>
        static public List<Students> StCom (List<Students> db)
        {
            return db.OrderBy(x => x.Age).ThenBy(x => x.Course).ToList();
        }
        /// <summary>
        /// Метод сортирующий список (путем сравнивания возраста) от меньшего к большему
        /// </summary>
        /// <param name="a">первый элемент</param>
        /// <param name="b">второй элемент</param>
        /// <returns></returns>
        static public int StudentsCompareAge (Students a, Students b)
        {
            return a.Age.CompareTo(b.Age);
        }
        /// <summary>
        /// Метод который заполняет список.
        /// </summary>
        /// <param name="db">передаваемый, как аргумент список </param>
        static public void FullList(List<Students> db)
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
        /// <summary>
        /// Метод для заполнения курса
        /// </summary>
        /// <param name="db">передаваемый элемент списка</param>
        /// <returns>возвращает число соответствующее номеру курса</returns>
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
