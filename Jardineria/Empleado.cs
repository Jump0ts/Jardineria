using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jardineria
{
    class Empleado
    {
		private String _nombre;
		private String _apellido;
		private String _email;

		public Empleado(String nombre, String apellido, String email)
		{
			this._nombre = nombre;
			this._apellido = apellido;
			this._email = email;
		}

		public String email
		{
			get { return _email; }
			set { _email = value; }
		}


		public String apellido
		{
			get { return _apellido; }
			set { _apellido = value; }
		}


		public String nombre
		{
			get { return _nombre; }
			set { _nombre = value; }
		}

	}
}
