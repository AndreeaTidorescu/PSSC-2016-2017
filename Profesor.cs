using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Profesor
    {
        string Name;
        string Departament;
        bool Sex;
        string Domain;
        int Age;
        string Email;

            public Profesor(string Name, string Departament, bool Sex, string Domain, int Age, string Email)
            {
                this.Name = Name;
                this.Departament = Departament;
                this.Sex = Sex;
                this.Domain = Domain;
                this.Age = Age;
                this.Email = Email;
            }
        }
}
