﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio81
{
    internal class Trabajador1 
    {
        //Campo de cada objeto Trabajador que almacena cuánto gana}
        public int Sueldo;

        Trabajador1(string nombre, int edad, string nif, int sueldo) : base(nombre, edad, nif)
        { //Inicializamos cada Trabajador en base al constructor de Persona
            Sueldo = sueldo;
        }
    }
}
