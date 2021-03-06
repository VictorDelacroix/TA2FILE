﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prueba
{
    public class Probar
    {
        public int Suma(int a, int b)
        {
            return a + b;
        }

        public string Unir(string a, string b)
        {
            if (a == null || b == null) return null;
            return a + b;
        }

        public bool CompararIguales(string a, string b)
        {
            if (a == b) return true;
            return false;
        }

        public bool CompararNumeros(int a, int b)
        {
            if (a == b) return true; return false;
        }

        public bool CompararArreglo(int[] a, int[] b)
        {
            if (a == b) return true; return false;
        }

        public int Dividir(int a, int b)
        {
                return a / b; 
        }
    }
}
