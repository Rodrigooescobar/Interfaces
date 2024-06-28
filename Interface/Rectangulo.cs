using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
	public class Rectangulo : Figura, ICalculable
	{

		public double Largo { get; set; }
        public double Ancho { get; set; }

		public Rectangulo(double largo, double ancho)
		{
			Largo = largo;
			Ancho = ancho;
		}

		public override void MostrarMensaje()
		{
            Console.WriteLine($"Largo {this.Largo} -- Ancho {this.Ancho} -- Area: {CalcularArea()} -- Perimetro {CalcularPerimetro()} ");
        }

		public double CalcularArea()
		{
			return Largo * Ancho;
		}

		public double CalcularPerimetro()
		{
			return 2 * Ancho + 2 * Largo;
		}
	}
}
