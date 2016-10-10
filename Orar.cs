using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class Orar
    {
        string Materie;
        string Profersor;
        string Tip;
        int An;
        string Loc;

        public Orar (string Materie, string Profesor, string Tip, int An, string Loc)
        {
            this.Materie = Materie;
            this.Profersor = Profersor;
            this.Tip = Tip;
            this.An = An;
            this.Loc = Loc;
        }
    }
}
