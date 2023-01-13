using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividades_UT62_Aplicaciones_con_más_de_una_vista
{
    class Persona
    {
		private string nombre;

		public string Nombre
		{
			get { return nombre; }
			set { nombre = value; }
		}

		private string nacionalidad;

		private int edad;

		public int Edad
		{
			get { return edad; }
			set { edad = value; }
		}

		public string Nacionalidad
		{
			get { return nacionalidad; }
			set { nacionalidad = value; }
		}


	}
}
