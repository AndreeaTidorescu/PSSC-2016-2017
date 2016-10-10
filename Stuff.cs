using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Stuff
    {
        string Type; // curs / seminar / laborator / proiect
        float Time;
        string Name;
        int Number_stud;
        string Loc;
        string Exam;

        public Stuff (string Type, float Time, string Nume, int Number_stud, string Loc, string Exam)
        {
            this.Type = Type;
            this.Time = Time;
            this.Name = Name;
            this.Number_stud = Number_stud;
            this.Loc = Loc;
            this.Exam = Exam;
        }
    }
}
