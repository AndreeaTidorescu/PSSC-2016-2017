using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tema1
{
    class Decanat
    {
        List<Materie> listMaterie = new List<Materie>();
        List<Student> listStudent = new List<Student>();
        public string nume_profesor { get; set; }
        public enum an_studiu { I,II,III,IV};
        public enum tip_disciplina { distribuita , examen};
        

        public Decanat (string nume_profesor)
        {
            this.nume_profesor = nume_profesor;
        }



    }

    class Profesor : Decanat
    {
        public float[] nota_examen { get; set; }
        public float[] nota_activitate { get; set; }
        public int[] prezenta { get; set; }
        public float nota_marire { get; set; }

        public Profesor(string nume_profesor, float[] nota_examen, float[] nota_activitate, int[] prezenta, float nota_marire) : base(nume_profesor)
        {
            this.nota_examen = nota_examen;
            this.nota_activitate = nota_activitate;
            this.prezenta = prezenta;
            this.nota_marire = nota_marire;
        }

    }

    class Student : Profesor
    {
        private string nume_student { get; set; }
        an_studiu AnStudiu;
        List<Materie> listMaterie = new List<Materie>();
        private bool marire_nota { get; set; }
        private int nr_matricol { get; set; }

        public Student(string nume_profesor, float[] nota_examen, float[] nota_activitate, int[] prezenta, float nota_marire, string nume_student, an_studiu AnStudiu, bool marire_nota, int nr_matricol) : base(nume_profesor, nota_examen, nota_activitate, prezenta, nota_marire)
        {
            this.nume_student = nume_student;
            this.AnStudiu = AnStudiu;
            this.marire_nota = marire_nota;
            this.nr_matricol = nr_matricol;
        }
    }

    class Materie : Decanat
    {
        public string nume_disciplina { get; set; }
        public int[] nr_credite { get; set; }
        tip_disciplina TipDisciplina;


        public Materie(string nume_profesor, string nume_disciplina, int[] nr_credite, tip_disciplina TipDisciplina) : base(nume_profesor)
        {
            this.nume_disciplina = nume_disciplina;
            this.nr_credite = nr_credite;
            this.TipDisciplina = TipDisciplina;
        }
    }


}
