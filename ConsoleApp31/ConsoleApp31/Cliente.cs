using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp31
{
    class Cliente {
        // campos, propiedades, constructures y metodos
        // propiedades (set = permito modificar, get=permito leer)
        public string Nombre {set; get;}
        public string Rut {set; get;}
        public string Direccion {set; get;}
	
        // funcion o metodo.
        public void Mostrar() {
            Debug.WriteLine("el nombre es "+Nombre+" y el rut es "+Rut);		
            Debug.WriteLine($"el nombre es {Nombre} y el rut es {Rut}");		
        }	
        // funcion que regresa un valor
        public string ObtenerDireccion() {
            return Direccion;
        }
        // funcion con argumentos.
        public int Sumar(int num1,int num2) {
            int suma=num1+num2;
            return suma;
        }
    }
}
