﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejerciciosguia0
{
    class Ejercicios
    {
        //ejercicio 1
        static void Main()
        {

            //  Console.WriteLine("Hola mundo00");
            //Console.ReadKey();

            //  Ejercicio2();
            //Ejercicio3();
            //Ejercicio4();
            //Ejercicio5();
            //Ejercicio6();
            //Ejercicio7();
            //Ejercicio8();
            // Ejercicio9();
            //Ejercicio10();
            // Ejercicio11();
            // Ejercicio12();
            //Ejercicio13();
            // Ejercicio14();
            //Ejercicio16();
            //Ejercicio17();
            //Ejercicio18();
            //Ejercicio19();
            //Ejercicio20();
            // Ejercicio21();
            //Ejercicio22();
            // Ejercicio25();
            //Ejercicio23();
            //Ejercicio29();
            Ejercicio30();

        }

        //ejercicio2

        public static void Ejercicio2()
        {
            string textousuario;
            Console.WriteLine("Ingrese un texto cualquiera");
            textousuario = Console.ReadLine();
            Console.WriteLine(textousuario);




        }

        //ejercicio3

        static void Ejercicio3()
        {
            string mensaje;
            do
            {

                Console.WriteLine("ingrese una frase");
                mensaje = Console.ReadLine();

            } while (mensaje != "fin");
        }


        //ejercicio4

        static void Ejercicio4()
        {
            string nombre;

            Console.WriteLine("Ingrese su nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("Hola " + nombre);





        }

        //ejercicio5

        static void Ejercicio5()
        {
            string frase;

            Console.WriteLine("Ingrese una frase");
            frase = Console.ReadLine();

            if (frase.Contains("fin"))
            {
                Console.WriteLine("Esta frase contiene la palabra fin");


            }
            else
            {
                Console.WriteLine("Esta frase no contiene la palabra fin");

            }




        }

        //ejercicio6
        static void Ejercicio6()
        {
            string palabra;
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();

            string palabramayuscula = palabra.ToUpper();

            Console.WriteLine(palabramayuscula);
        }

        //Ejercicio7

        static void Ejercicio7()
        {
            string palabra;
            Console.WriteLine("Ingrese una palabra");
            palabra = Console.ReadLine();

            string palabraminuscula = palabra.ToLower();
            Console.WriteLine(palabraminuscula);
        }

        //Ejercicio8

        static void Ejercicio8()
        {
            string frase;

            Console.WriteLine("Ingese una frase");
            frase = Console.ReadLine();

            string frasesinacento = frase.Replace("á", "a")
                                .Replace("é", "e")
                                .Replace("í", "i")
                                .Replace("ó", "o")
                                .Replace("ú", "u");

            Console.WriteLine(frasesinacento);



        }

        static void Ejercicio9()
        {

            Console.WriteLine("Ingrese una frse");
            string frase1 = Console.ReadLine();
            Console.WriteLine("Ingrese otra frase");
            string frase2 = Console.ReadLine();

            if (frase1 == frase2)
            {

                Console.WriteLine("Estas frases son iguales");
            }
            else
            {
                Console.WriteLine("Estas frases no son iguales <3");



            }
        }
        //Ejercicio10
        static void Ejercicio10()
        {
            Console.WriteLine("Ingrese una frse");
            string frase1 = Console.ReadLine();
            Console.WriteLine("Ingrese otra frase");
            string frase2 = Console.ReadLine();

            if (frase1.Length == frase2.Length)
            {

                Console.WriteLine("Las frases tienen la misma longitud");
            }
            else
            {
                Console.WriteLine("Las frases tienen distinta longitud");
            }
        }

        static void Ejercicio11()
        {
            Console.WriteLine("Ingrese una frase");
            string frase1 = Console.ReadLine();
            Console.WriteLine("Ingrese otra frase");
            string frase2 = Console.ReadLine();

            if (frase1.ToUpper() == frase2.ToUpper())
            {

                Console.WriteLine("Estas frases son iguales");
            }
            else
            {
                Console.WriteLine("Estas frases no son iguales <3");



            }
        }

        static void Ejercicio12()
        {

            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine();
            int cantpalabras = frase.Split(' ').Length;

            Console.WriteLine("La cantidad de palabras que tiene esta palabra son: " + cantpalabras);

        }


        static void Ejercicio13()
        {

            Console.WriteLine("Ingrese una frase");
            string frase = Console.ReadLine();
            int cantpalabras = frase.Split(' ', '.').Length;

            Console.WriteLine("La cantidad de palabras que tiene esta palabra son: " + cantpalabras);
        }


        static void Ejercicio14()
        {
            String numero;
            float salida;
            bool flag = false;

            Console.WriteLine("Ingrese un número");
            numero = Console.ReadLine();

            do
            {
                if (!float.TryParse(numero, out salida))
                {

                    Console.WriteLine("El dato ingresado no es numérico");
                    break;
                }
                else
                {
                    flag = true;
                    Console.WriteLine("Este es un dato numérico");
                }


            } while (flag == false);
        }


        static void Ejercicio15()
        {
            string numeroentero;
            int salida;
            bool flag = false;

            Console.WriteLine("Ingrse un numero entero");
            numeroentero = Console.ReadLine();
            do
            {

                if (!int.TryParse(numeroentero, out salida))
                {
                    Console.WriteLine("Este no es un numero entero");
                    break;
                }
                else
                {
                    flag = true;
                    Console.WriteLine("Este es un número entero");
                }

            } while (flag == false);


        }


        static void Ejercicio16()
        {
            int numero1 = 0, numero2 = 0;
            bool flag = false;



            do
            {

                Console.WriteLine("Ingrese un número");
                string input1 = Console.ReadLine();
                Console.WriteLine("Ingrese otro número");
                string input2 = Console.ReadLine();

                if (!int.TryParse(input1, out numero1) || !int.TryParse(input2, out numero2))
                {

                    Console.WriteLine("alguno de estos datos no es un numero");

                }
                else
                {
                    flag = true;

                }

            } while (flag == false);



            int suma = numero1 + numero2;
            int resta = numero1 - numero2;
            int division = numero1 / numero2;
            double potencia = Math.Pow(numero1, numero2);

            Console.WriteLine("la suma de los numerós" + numero1 + numero2 + "es: " + suma);

        }

        static void Ejercicio17()
        {
            double numero1;
            bool flag = false;



            do
            {
                Console.WriteLine("Ingrese un número");
                string input1 = Console.ReadLine();

                if (!double.TryParse(input1, out numero1))
                {
                    Console.WriteLine("Este no es un valor numérico");
                }
                else
                {
                    flag = true;
                }
            } while (flag == false);

            double numero1redondeado = Math.Round(numero1);

            Console.WriteLine("El nuúmero que nos dió, redondeado queda así: " + numero1redondeado);
        }
        //Ejercicio18
        static void Ejercicio18()
        {
            double numero1;
            bool flag = false;
            
            do
            {
                Console.WriteLine("Ingrese un número");
                string numero = Console.ReadLine();

                if (!double.TryParse(numero,out numero1))
                {


                    Console.WriteLine("El valor ingresado no es un número");
                }
                else
                {
                    flag = true;
                }
            }while (flag == false);

            int parteentera = (int)numero1;
            Console.WriteLine("La parte entera del numero ingresado es. " + parteentera);

        }
        //Ejercicio19

        static void Ejercicio19()
        {
            bool Flag = false;
            int numero1=0;
            int numero2=0;
            do
            {
                Console.WriteLine("Ingrese el primer número");
                string input1 = Console.ReadLine();
                Console.WriteLine("Ingrese el segundo número");
                string input2 = Console.ReadLine();

                if (!int.TryParse(input1, out numero1) || !int.TryParse(input2, out numero2))
                {
                    Console.WriteLine("Alguno de los valores que ingreso no es un número entero");

                }
                else
                {
                    Flag = true;

                }


            } while (Flag == false);


            if (numero1>numero2)
            {

                Console.WriteLine("El valor " + numero1 + " es mayor que el valor " + numero2);

            }
            else if(numero1<numero2)
            {

                Console.WriteLine("El valor " + numero2 + " es mayor que el valor " + numero1);

            }
            else
            {
                Console.WriteLine("Ambos valores son iguales");
            }



        }
        //Ejercicio20
        static void Ejercicio20()
        {

            DateTime fechahoy = DateTime.Now;
            Console.WriteLine("La fecha del día de hoy es: " + fechahoy);
            
        }
        //Ejercicio21
        static void Ejercicio21()
        {
            DateTime fechahoy = DateTime.Now;
            string fechaformateada = fechahoy.ToString("dd / MM / yyyy");
            Console.WriteLine("La fecha del día de hoy es: " + fechaformateada);
        }
        //Ejercicio22
        static void Ejercicio22()
        {
            bool flag = false;
            DateTime fecha;
            

            do
            {
                Console.WriteLine("Ingrese una fecha");
                string input = Console.ReadLine();

                if (!DateTime.TryParse(input,out fecha))
                {
                    Console.WriteLine("Lo que ingreso no es una fecha");
                }
                else
                {
                    flag = true;
                }
            } while (flag == false);


        }
        //Ejercicio23

        static void Ejercicio23()
        {
            bool flag = false;
            DateTime fecha;
            do
            {
                Console.WriteLine("Ingrese una fecha con formato dd/MM/yyyy");
                string input = Console.ReadLine();
                if(!DateTime.TryParseExact(input, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out fecha))
                {

                }
                else
                {
                    flag |= true;
                }

            } while (flag==false);

            Console.WriteLine("la fecha inresada es: " + fecha);
        }
       //Ejercicio24
        static void Ejercicio24()
        {
            bool flag = false;

            do
            {
                Console.WriteLine("Ingrese un día");
                int dia = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un mes");
                int mes = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ingrese un año");
                int año = Convert.ToInt32(Console.ReadLine());

                if (dia >= 1 && dia <= 30)
                {
                    Console.WriteLine("El día está bien");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("No puso bien el día");

                }
                if (mes > 01 && mes <= 12)
                {
                    Console.WriteLine("El mes está bien");
                    flag = true;
                }
                else
                {
                    Console.WriteLine("No puso bien el mes");
                }
                if (año < 2025)
                {

                    Console.WriteLine("El año está bien");
                    flag = true;
                }
                else
                {

                    Console.WriteLine("No puso bien el año");
                }
            } while (flag == false);
            


        }
        //Ejercicio25
        static void Ejercicio25()
        {
            bool flag = false;
            DateTime fecha;


            do
            {
                Console.WriteLine("Ingrese una fecha");
                string input = Console.ReadLine();

                if (!DateTime.TryParse(input, out fecha))
                {
                    Console.WriteLine("Lo que ingreso no es una fecha");


                }
                else
                {
                    flag = true;
                }

            } while (flag == false);

            int día = fecha.Day;
            int mes = fecha.Month;
            int año = fecha.Year;

            string nombremes=fecha.ToString("MMM");
            string nombrediadelasemana = fecha.ToString("dd");
            int numerodediadelasemana = (int)fecha.DayOfWeek +1;

            Console.WriteLine("el día: " + día + ", el año: " + año + ", el número y nombre del mes: " + mes + nombremes + " y el nombre y número del día de la semana: " + nombrediadelasemana + numerodediadelasemana);
        }
        //Ejercicio26

        static void Ejercicio26()
        {
            bool flag = false;
            DateTime fecha;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                string input = Console.ReadLine();

                if(!DateTime.TryParseExact(input,"dd/MM/yyy", CultureInfo.InvariantCulture,DateTimeStyles.None,out fecha))
                {

                    Console.WriteLine("El valor ingresado no es una fecha en el formato dd/MM/yyyy");

                }
                else
                {
                    flag = true;

                }

            } while (flag==false);

            DateTime fecha30dias = fecha.AddDays(30);
            DateTime fecha60dias = fecha.AddDays(60);
            DateTime fecha180dias = fecha.AddDays(180);

            Console.WriteLine("La fecha ingresada más 30 días: " + fecha30dias + ", la fecha ingresada más 60 días: " + fecha60dias + " y la fecha ingresada más 180 días: " + fecha180dias);




        }

        //Ejericio28

        static void Ejercicio28()
        {
            bool flag = false;
            DateTime fecha;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                string input=Console.ReadLine();

                if (!DateTime.TryParseExact(input,"dd/MM/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None, out fecha))
                {
                    Console.WriteLine("El valor ingresado no tiene el formato correcto");
                }
                else
                {
                    flag = true;

                }

            } while (flag==false);


            DateTime mesanterior = fecha.AddMonths(-1);
            DateTime primerodelmesanterior = new DateTime(1, mesanterior.Month, mesanterior.Year);


            Console.WriteLine("El primero del mes anterior es : " + primerodelmesanterior);

        }

        //Ejercicio29 (mandar al profe)

        static void Ejercicio29()
        {
            bool flag = false;
            DateTime fecha;
            do
            {
                Console.WriteLine("Ingrese una fecha");
                String input = Console.ReadLine();
                if(!DateTime.TryParseExact(input,"dd/MM/yyyy HH:mm:ss",CultureInfo.InvariantCulture,DateTimeStyles.None,out fecha))
                {
                    Console.WriteLine("El valor ingreado no es una fecha o no tiene el formato correspondiente");

                }
                else
                {
                    flag = true;
                }

            } while (flag==false);

            TimeSpan hora = fecha.TimeOfDay;
            Console.WriteLine("La hora de la fecha ingresada es: " + hora);

        }

        //Ejercicio30

        static void Ejercicio30()
        {
            bool flag = false;
            TimeSpan intervalo;
            do
            {
                Console.WriteLine("Ingrese un intervalo de tiempo");
                string input = Console.ReadLine();

                if (!TimeSpan.TryParse(input,out intervalo))
                {
                    Console.WriteLine("El valor ingresado no es un intervalo de tiempo");

                }
                else
                {

                   flag= true;
                    Console.WriteLine("El valor ingresado es un intervalo de tiempo");
                }
            } while (flag == false);





        }


        //Ejercicio31(falta hacer)
        static void Ejercicio31()
        {


        }

        //Ejercicio32(FALTA HACER9

        static void Ejercicio32()
        {
            bool flag = false;
            DateTime fecha;
            do
            {
                Console.WriteLine("Ingrese una fecha con el formato dd/MM/yyyy");
                string input=Console.ReadLine();
                if (!DateTime.TryParseExact(input,"dd/MM/yyyy",CultureInfo.InvariantCulture,DateTimeStyles.None,out fecha))
                {
                    Console.WriteLine("Elvalor ingresado no tiene el formato correcto");
                }
                else
                {
                    flag= true;
                }

            } while (flag==false);

            int mes=fecha.Month;
            int mesesquefaltanparafindeaño = 12 - mes;






        }


        //Ejercicio33

        static void Ejercicio33()
        {
            DateTime endtime = DateTime.Now.AddMinutes(1);
            do
            {
                DateTime fecha = DateTime.Now;
                Console.WriteLine("La fecha actual es: " + fecha);
                System.Threading.Thread.Sleep(10000);

            } while (DateTime.Now<endtime);
        }

























































    }

        
        
        
        
     



















































}












        









