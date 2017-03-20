using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    class Students
    {
        public string Student { get; set; }
        public int Age { get; set; }
        public int Course { get; set; }
        List<Students> db = new List<Students>();
        public void FullList()
        {
            Random r = new Random();
            for (int i = 0; i < 100; i++)
            {
                db.Add(new Students()
                {
                    Student = $" Student : {i + 1}",
                    Age = r.Next(18, 23),
                    Course = FullCourse(db[i])
                });
            }
        }
        public int FullCourse(Students db)
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
