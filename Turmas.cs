using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace BaseClasses
 {
    public class Turma : Cursos

    {       
        public DateTime Inicio;
        public string Modulos;
        internal int NumeroMinimoDeAlunos;
        internal int NumeroMaximoDeAlunos;
        public string Sala;
        public int NumeroFormadores;

     }
}
