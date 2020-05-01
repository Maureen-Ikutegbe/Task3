using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    public class MyList 
    {
        public List<Task> Tasks = new List<Task>();
    }

    public class Task
    {

        public  string NameOfActivity { get; set; }
        public  string DayOfTheWeek { get; set; }
        public  bool Completed { get; set; }
        
        public Task(string nameOfActivity, string dayOfTheWeek, bool completed)
        {
            NameOfActivity = nameOfActivity;
            DayOfTheWeek = dayOfTheWeek;
            Completed = completed;

        }

    }

    

}
