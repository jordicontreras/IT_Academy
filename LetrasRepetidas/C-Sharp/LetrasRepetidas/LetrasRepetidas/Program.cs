using System;
using System.Collections.Generic;
using System.Linq;

namespace LetrasRepetidas
{
    class Program
    {
        static void Main(string[] args)
        {
            //*********** FASE 1 ***********

            //Creamos el array de nombre e introducimos sus valres
            char[] nombre = new char[5];
            nombre[0] = 'j';
            nombre[1] = 'o';
            nombre[2] = 'r';
            nombre[3] = 'd';
            nombre[4] = 'i';
            

            //Recorremos el array para imprimir sus valores por consola
            foreach (char valor in nombre)
            {
                //Escribimos el valor por consola
                Console.WriteLine($"{valor}");
            }


            //*********** FASE 2 y 4 ***********

            Console.WriteLine("AHORA CON LISTAS");
            //Llamamos a la función para crear una lista de nuestro array
            NombreConListas();


            //*********** FASE 3 ***********
            //Llamamos a la función que comprueba si hay valores repetidos e introduce los datos en el diccionario
            metemosEnDiccionario(nombre);
        }

        public static void NombreConListas()
        {
            //Creamos la lista de chars para nombre y apellidos
            var nombre = new List<char>();
            var apellido = new List<char>();
            var esNumero = false;
            //Añadimos los caracteres del nombre a la lista
            nombre.Add('j');
            nombre.Add('o');
            nombre.Add('r');
            nombre.Add('d');
            nombre.Add('i');

            //Añadimos los caracteres del apellido a la lista
            apellido.Add('c');
            apellido.Add('o');
            apellido.Add('n');
            apellido.Add('t');
            apellido.Add('r');
            apellido.Add('e');
            apellido.Add('r');
            apellido.Add('a');
            apellido.Add('s');

            Console.WriteLine("Fusionamos listas");
            fusionaListas(nombre, apellido);


            foreach (char letra in nombre)
            {
                //Comprobamos si los caracteres son vocales
                if(letra == 'a'  || letra == 'e'  || letra == 'i' || letra == 'o' || letra == 'u')
                {
                    Console.WriteLine($"{letra} es una VOCAL");
                }
                else
                {
                    int num2;             
                    //Intentamos convertir el caracter a Integer, si funciona resolvemos que el caracter es un número
                    esNumero = int.TryParse(letra.ToString(), out num2);
                    if (esNumero == true)
                    {
                        Console.WriteLine($"{letra} es una número y por tanto no válido");
                    }
                    else
                    {
                        Console.WriteLine($"{letra} es una CONSONANTE");
                    }
                    
                    //Otra posible solución para controlar si un caracter es número, con el método IsNumber
                    /*
                    if (Char.IsNumber(letra))
                    {
                        Console.WriteLine($"{letra} es una número y por tanto no válido");
                    }
                    else
                    {
                        Console.WriteLine("Els noms de persones no contenen números!");
                    }
                    */
                }
            }
        }

        public static void metemosEnDiccionario(char[]  nombre)
        {
            //Creamos diccionario
            var diccionario = new Dictionary<char, int>();
            
            //Recorremos el array y añadiremos los valores y el número de veces que aparecen
            for(int i=0; i<nombre.Length; i++)
            {
                var cont = 0;
                for (int j=i; j<nombre.Length; j++)
                {
                    
                    if (nombre[i] == nombre[j])
                    {
                        cont++;
                    }
                }
                if (!diccionario.ContainsKey(nombre[i]))
                {
                    diccionario.Add(nombre[i], cont);
                }
                    
            }

            //Recorremos el diccionario y mostramos sus valores
            foreach (KeyValuePair<char, int> entry in diccionario)
            {
                Console.WriteLine("la letra es: " + entry.Key + " y el num de veces es: " + entry.Value);
            }

            
        }
        

        public static void fusionaListas(List<char> nombre, List<char> Apellido)
        {
            var espacio = new List<char>();
            espacio.Add(' ');
            var nombreCompleto = new List<char>();
            nombreCompleto = nombre.Concat(espacio).ToList();
            nombreCompleto = nombreCompleto.Concat(Apellido).ToList();

            foreach (char letra in nombreCompleto)
            {
                Console.Write(letra);
            }
            Console.WriteLine();
        }
    }
}
