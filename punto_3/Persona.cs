using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace punto_3
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        private DateTime fechaNac;
        private string direccion;

        //getters - setters
        public string _nombre { get => nombre; set=> nombre = value; }
        public string _apellido { get => apellido; set=> apellido = value; }
        public string _dni { get => dni; set=> dni = value; }
        public DataTime _fechaNac { get => fechaNac; set=> fechaNac = value; }
        public string _direccion { get => direccion; set=> direccion = value; }



        //constructor
        public Persona (string nombre, string apellido, string dni, DateTime fechaNac, string direccion)
        {
            this.nombre = _nombre;
            this.apellido = _apellido;
            this.dni = _dni;
            this.fechaNac = _fechaNac;
            this.direccion = _direccion;
        }
        
    }

    public class Empleado: Persona
    {
        private DateTime fechaIng;
        private string puesto;
        private int antiguedad;
        private float salarioBasico;
        private string estadoCivil;
        private DateTime fechaDivorcio;
        private int cantHijos;
        private char titulo; //Si = S - No = N
        private string universidad;
        private string titulo_univ;

       
        public DataTime _fechaIng { get => fechaIng; set => fechaIng = value; }
        public string _puesto { get => puesto; set => puesto = value; }
        public int _antiguedad { get => antiguedad; set => antiguedad = value; }
        public float _salarioBasico { get => salarioBasico; set => salarioBasico = value; }
        public string _estadoCivil { get => estadoCivil; set => estadoCivil = value; }
        public DataTime _fechaDivorcio { get => fechaDivorcio; set => fechaDivorcio = value; }
        public int _cantHijos { get => cantHijos; set => cantHijos = value; }
        public string _titulo { get => titulo; set => titulo = value; }
        public string _universidad { get => universidad; set => universidad = value; }
        public string _titulo_univ { get => titulo_univ; set => titulo_univ = value; }
        
        //Constructor
        public Empleado () { }

        public Empleado (string nombre, string apellido, string dni, DateTime fechaNac, string direccion,
                         DataTime fechaIng, string puesto, int antiguedad, float salarioBasico, string estadoCivil,
                         DataTime fechaDivorcio, int cantHijos, char titulo, string universidad, string titulo_univ)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.fechaNac = fechaNac;
            this.direccion = direccion;
            this.fechaIng = fechaIng;
            this.puesto = puesto;
            this.antiguedad = antiguedad;
            this.salarioBasico = salarioBasico;
            this.estadoCivil = estadoCivil;
            this.fechaDivorcio = fechaDivorcio;
            this.cantHijos = cantHijos;
            this.titulo = titulo;
            this.universidad = universidad;
            this.titulo_univ = titulo_univ;
        }

        public int calcularAntiguedad (DateTime fechaIng)
        {
            int antiguedad;
            DateTime fechaActual = DateTime.Today;

            antiguedad = fechaActual.Year - fechaIng.Year;

            return antiguedad;
        }

        public int calcularEdad (DateTime fechaNac)
        {
            int edad;
            DateTime fechaActual = DateTime.Today;

            antiguedad = fechaActual.Year - fechaIng.Year;

            return edad;
        }

        public float salario (float salarioBasico, int antiguedad)
        {
            float descuento, adicional, salario;

            descuento = salarioBasico * 0.15;
            //adicional
            if (antiguedad >= 20)
            {
                adicional = salarioBasico * 0.25;
            }
            else
            {
                adicional = (salarioBasico * 0.01) * antiguedad;
            }

            salario = salarioBasico + adicional - descuento;

            return salario;
        }
        

    }
    
}