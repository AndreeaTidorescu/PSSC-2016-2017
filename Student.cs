using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Student
    {
        string Nume;
        string Specializare;
        int An;
        int Grupa;
        bool Restanta;
        int Nr_Matricol;

        public Student (string Nume, string Specializare , int An, int Grupa, bool Restanta, int Nr_Matricol)
        {
            this.Nume = Nume;
            this.Specializare = Specializare;
            this.An = An;
            this.Grupa = Grupa;
            this.Restanta = Restanta;
            this.Nr_Matricol = Nr_Matricol;


        }
    }
}
