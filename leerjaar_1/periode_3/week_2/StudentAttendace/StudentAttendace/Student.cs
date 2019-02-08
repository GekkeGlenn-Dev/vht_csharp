using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentAttendace
{
    class Student
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string SurName { get; set; }
        public bool AttendingClass { get; set; }
        public string ShirtColor { get; set; }
        public string PantsColor { get; set; }

        public string Greet()
        {
            return String.Format("Student: D{0}, {1}, {2}, {3}, {4}, {5}", Id, FirstName, SurName, AttendingClass, ShirtColor, PantsColor) ;
        }
    }
}
