using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace PRIMER_PROGRAMA     


{
    class Program
    {
        static void Main(string[] args)
        {
            bool salir = false;
            Console.WriteLine("CALCULADORA SIMPLE");
            
            
            while (!salir)
            {
                Console.WriteLine("--------------------------------");      // MENÚ PRINCIPAL - Agregar funcionalidades
                Console.WriteLine("1 - Sumar dos numeros");
                Console.WriteLine("2 - Restar dos numeros");
                Console.WriteLine("3 - Multiplicar dos numeros");
                Console.WriteLine("4 - Divide dos numeros");
                Console.WriteLine("5 - Salir");
                Console.WriteLine("6 - Palindromo");
                Console.WriteLine("7 - Ordenar una Lista");
                String Opcion0 = Console.ReadLine();                               
                int Opcion = Convert.ToInt32(Opcion0);

                // check de la opción ingresada por el usuario
                // se evualua la presencia de carácteres alfanuméricos principalmente            
                
                if(AlfaChecker(Opcion0) == false)
                {
                    Console.WriteLine("");
                    Console.WriteLine("ERROR: Ingrese una opción que no contenga letras");
                }
                else
                {
                    
                    switch (Opcion)
                    {
                        case 1:
                            Console.WriteLine("");
                            Console.WriteLine("Escriba su primer número, luego presione Enter");
                            String numero = Console.ReadLine();
                            Console.WriteLine("Escriba su segundo número");
                            String numero2 = Console.ReadLine();
                            int Suma = Convert.ToInt32(numero) + Convert.ToInt32(numero2);
                            Console.WriteLine("EL RESULTADO ES: " + Suma);
                            Console.WriteLine("");
                            break;

                        case 2:
                            Console.WriteLine("");
                            Console.WriteLine("Escriba su primer número, luego presione Enter");
                            String numero3 = Console.ReadLine();
                            Console.WriteLine("Escriba su segundo número");
                            String numero4 = Console.ReadLine();
                            int resta = Convert.ToInt32(numero3) - Convert.ToInt32(numero4);
                            Console.WriteLine("EL RESULTADO ES: " + resta);
                            Console.WriteLine("");
                            break;

                        case 3:
                            Console.WriteLine("");
                            Console.WriteLine("Escriba su primer número, luego presione Enter");
                            String numero5 = Console.ReadLine();
                            Console.WriteLine("Escriba su segundo número");
                            String numero6 = Console.ReadLine();
                            int mult = Convert.ToInt32(numero5) * Convert.ToInt32(numero6);
                            Console.WriteLine("EL RESULTADO ES: " + mult);
                            Console.WriteLine("");
                            break;

                        case 4:
                            Console.WriteLine("");
                            Console.WriteLine("Escriba su primer número, luego presione Enter");
                            String numero7 = Console.ReadLine();
                            Console.WriteLine("Escriba su segundo número");
                            String numero8 = Console.ReadLine();
                            decimal div = Convert.ToDecimal(numero7) / Convert.ToInt32(numero8);
                            Console.WriteLine("EL RESULTADO ES: " + div);
                            Console.WriteLine("");
                            break;

                        case 5:
                            Console.WriteLine("FIN");
                            salir = true;
                            break;

                        case 6:
                            Console.WriteLine("");
                            Console.WriteLine("TIP: Un Palíndromo es una palabra o expresión que es igual si se escribe de izquierda a derecha y viceversa (ejemplo: reconocer");
                            Console.WriteLine("");
                            Console.WriteLine("Escriba su palabra para ser analizada, luego presione Enter");
                            string analize = Console.ReadLine();
                            Console.WriteLine("");
                            Console.WriteLine(Palindromo(analize));
                            break;
                        case 7:
                            Console.WriteLine("");
                            Console.WriteLine("Escriba nombres, apellidos o lo que usted quiera. Cuando digite 'Salir' el programa le mostrará esa lista ordenada alfabéticamente");
                            Console.WriteLine("");
                            Console.WriteLine("Ingrese su primera palabra: ");
                            String p = Console.ReadLine();
                            ArrayList letras = new ArrayList();
                            while(EsSalir(p) == false)
                            {
                                Console.WriteLine("Agregado! Ingrese otra palabra!");
                                letras.Add(p);
                                p = Console.ReadLine();
                            }
                            letras.Sort();
                            string string2 = "";
                            foreach (string i in letras)
                            {                                
                                string2 += i + ", ";
                            }
                            Console.WriteLine(Print(string2));                                                        
                            break;                       

                        default:
                            Console.WriteLine("");
                            Console.Write("Ingrese un número que esté en el Menú");
                            Console.WriteLine("");
                            Console.WriteLine("");
                            break;

                    }                
                }
            }

            
        }
        static string Print(string hola)
        {
            return hola;
        }
        static bool EsSalir(string palabra)
        {
            if(palabra == "Salir")
            {
                return true;
            }
            return false;

        }
        static int Sumatoria(int numero,int numero2)
        {
            return numero + numero2;
        }
        static int Resta(int numero,int numero2)
        {
            return numero - numero2;
        }
        /// <summary>
        /// Multiplica dos números enteros
        /// </summary>
        /// <param name="numero"> primer número </param>
        /// <param name="numero2"> segundo número </param>
        /// <returns></returns>
        static int Multiplicacion( int numero, int numero2)
        {
            return numero * numero2;
        }
        /// <summary>
        /// Divide dos números enteros
        /// </summary>
        /// <param name="numero"> Dividendo </param>
        /// <param name="numero2"> Divisor </param>
        /// <returns></returns>
        static int Division( int numero, int numero2)
        {
            return numero / numero2;
        }

        /// <summary>
        /// Verifica si un string en cuestión, es un palindromo o no
        /// </summary>
        /// <param name="palabra">String a verificar</param>
        /// <returns></returns>
        static string Palindromo(string palabra)
        {
            int Longitud = palabra.Length;
            string alreves = new string(palabra.Reverse().ToArray());
            bool ultima = palabra == alreves;
            if (ultima == true)
            {
                return "ES UN PALÍNDROMO";
            }
            else
            {
                return "NO ES UN PALÍNDROMO";
            }
        }
        /// <summary>
        /// Verifica que lo ingresado unicamente contenga números
        /// </summary>
        /// <param name="palabra"> String ingresado por el usuario a analizar </param>
        /// <returns></returns>
        static bool AlfaChecker(string palabra)
        {
            int longitud = palabra.Length;
            for (int i = 0; i < longitud;i++)
            {
                String ABC = "ABCDEFGHIJKLMNÑOPQRSTUVWXYZabcdefghijklmnñopqrstuvwxyz!@#·~$€%¬&/()?¿";
                if (ABC.Contains(palabra)){
                    return false;               
                }
                else
                {
                    continue;
                }
               
            }
            return true;
        }
        
    }

}
