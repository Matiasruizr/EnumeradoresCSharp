using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solucion.Modelo
{
    public class Persona
    {
        private Sexo _sex;
        private EstadoCivil estadoCivil;
        private string _nombre;
        private int _rut;
        private string _dv;

        public string DV
        {
            get { return _dv; }
            set { _dv = value; }
        }


        public int Rut
        {
            get { return _rut; }
            set { _rut = value; }
        }


        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }


        public EstadoCivil EstCivil
        {
            get { return estadoCivil; }
            set { estadoCivil = value; }
        }


        public Sexo Sex
        {
            get { return _sex; }
            set { _sex = value; }
        }

        public override string ToString()
        {

            //Strong builder
            StringBuilder sb = new StringBuilder();
            sb.Append(string.Format("Nombre: {0}, ",_nombre));
            sb.Append(string.Format("Rut: {0}-{1}, ", _rut, _dv));
            return sb.ToString();
         
        }

    }
}
