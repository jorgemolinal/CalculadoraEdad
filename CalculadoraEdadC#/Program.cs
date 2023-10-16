using CalculadoraEdadC_;
using System;
using System.Diagnostics.Metrics;
using System.Net.Http.Headers;
using System.Numerics;

namespace CalculadoraEdad
{
    class Program
    {
        private static List<DateTime> fechasNacimiento = new List<DateTime>(); //Variable global, utilizada para los planetas
        private static Edad CalculaEdad(DateTime fechaFutura, DateTime fechaAnterior)
        {
            int edadAnios = fechaFutura.Year - fechaAnterior.Year;
            int edadMeses = fechaFutura.Month - fechaAnterior.Month;
            int edadDias = fechaFutura.Day - fechaAnterior.Day;
            if (edadDias < 0)
            {
                edadMeses--;
                int ultimoDiaMesPrevio = DateTime.DaysInMonth(fechaFutura.Year, fechaFutura.Month - 1);
                edadDias += ultimoDiaMesPrevio;
            }
            if (edadMeses < 0)
            {
                edadAnios--;
                edadMeses += 12;
            }
            Edad edad = new Edad(edadAnios, edadMeses, edadDias);
            return edad;
        }
        private static int CalculadoraEdadPlaneta(DateTime fechaFutura, DateTime fechaAnterior, string Planeta)
        { //En la tierra hay 365 dias terrestres y en otro planeta son x dias
            Edad edadTierra = CalculaEdad(fechaFutura, fechaAnterior);
            int diasTierra = edadTierra.edadAnios * 365 + edadTierra.edadMeses * 30 + edadTierra.edadDias;
            int diasPlaneta=0;
            if (Planeta == "mercurio")
            {
                diasPlaneta = 88;
            }
            else if (Planeta == "jupiter")
            {
                diasPlaneta = 4329;
            }
            else if (Planeta == "marte")
            {
                diasPlaneta = 687;
            }
            else if (Planeta == "venus")
            {
                diasPlaneta = 225;
            }
            else if (Planeta == "saturno")
            {
                diasPlaneta = 10753;
            }
            else if (Planeta == "urano")
            {
                diasPlaneta = 30664;
            }
            else { Console.WriteLine("Algo ha pasado con los planetas"); }
            
            int edadPlaneta = diasTierra / diasPlaneta;
            return edadPlaneta;
        }


        static void Main(string[] arg)
        {
            bool finDelPrograma = true;
            while (finDelPrograma)
            {
                Console.WriteLine("***********************************************");
                Console.WriteLine("Bienvenido, elige en el menú que quieres hacer:");
                Console.WriteLine("[1] calcula tu edad");
                Console.WriteLine("[2] tu edad en un futuro");
                Console.WriteLine("[3] Calculo de edades en otros planetas");
                Console.WriteLine("[0] abandonar pantalla");
                string accion = Console.ReadLine();

                switch (accion)
                {
                    case "[0]":
                    case "0":
                        finDelPrograma = false;
                        break;
                    case "[1]":
                    case "1":
                        caso1();
                        break;

                    case "[2]":
                    case "2":
                        caso2();
                        break;

                    case "[3]":
                    case "3":
                        caso3();
                        break;

                    default:
                        Console.WriteLine("La respuesta no es parte de las opciones");
                        break;
                }
            };
            
        }
       
        private static void caso3()
        {
            Console.WriteLine("[1] añadir edades");
            Console.WriteLine("[2] edades en Mercurio");
            Console.WriteLine("[3] edades en Pluton");
            Console.WriteLine("[4] edades en Venus");
            Console.WriteLine("[5] edades en Marte");
            Console.WriteLine("[6] edades en Saturno");
            Console.WriteLine("[7] edades en Urano");
            Console.WriteLine("[0] mostrar edades registradas");
            Console.WriteLine("[salir] para volver al menú anterior");
            string accion = Console.ReadLine();

            switch (accion)
            {
                case "1":
                case "[1]":
                    Console.Write("Ingrese una fecha de nacimiento: ");
                    string fechaNacimientoStr = Console.ReadLine();

                    if ((DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento)))
                    {
                        fechasNacimiento.Add(fechaNacimiento);
                    }
                    else
                    {
                        Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
                    }
                    caso3();
                    break;

                case "2":
                case "[2]":
                    llamadaPlaneta("mercurio");
                    caso3();
                    break;

                case "3":
                case "[3]":
                    llamadaPlaneta("jupiter");
                    caso3();
                    break;
                case "4":
                case "[4]":
                    llamadaPlaneta("venus");
                    caso3();
                    break;
                case "5":
                case "[5]":
                    llamadaPlaneta("marte");
                    caso3();
                    break;
                case "6":
                case "[6]":
                    llamadaPlaneta("saturno");
                    caso3();
                    break;
                case "7":
                case "[7]":
                    llamadaPlaneta("urano");
                    caso3();
                    break;
                case "0":
                case "[0]":
                    foreach (DateTime fecha in fechasNacimiento)
                    {
                        Console.WriteLine($"- {fecha}.");
                    }
                    break;
                case "00":
                case "salir":
                case "SALIR":
                case "Salir":
                case "[salir]":
                    break;
                default:
                    Console.WriteLine("Opcion incorrecta");
                    caso3();
                    break;

            }

        }
        private static void llamadaPlaneta(string Planeta)
        {
            DateTime fechaActual = DateTime.Now;
            foreach (DateTime fecha in fechasNacimiento) //Recorre elementos (DateTime) de la lista.
            {
                int anos = CalculadoraEdadPlaneta(fechaActual, fecha, Planeta);
                Console.WriteLine($"La fecha de nacimiento es {fecha} y tendría {anos} años en {Planeta}.");
            }

        }
        private static void caso2()
        {
            if (formatoAnos())
            {
                Console.Write("Ingrese su fecha de nacimiento: ");
                string fechaNacimientoStr = Console.ReadLine();

                Console.Write("Ingrese una fecha futura: ");
                string fechaFuturaStr = Console.ReadLine();

                if ((DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento) && (DateTime.TryParseExact(fechaFuturaStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaFutura))))
                {
                    Edad edad = CalculaEdad(fechaFutura, fechaNacimiento);
                    if (edad.edadAnios > 0 && edad.edadMeses > 0 && edad.edadDias > 0)
                    {
                        Console.WriteLine($"Su edad seria: {edad.edadAnios} años, {edad.edadMeses} meses y {edad.edadDias} días.");
                    }
                    else
                    {
                        Console.WriteLine("No habias nacido");
                    }

                }
                else
                {
                    Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
                }
            } else
            {
                Console.Write("Ingrese su fecha de nacimiento: ");
                string fechaNacimientoStr = Console.ReadLine();

                Console.Write("Ingrese una fecha futura: ");
                string fechaFuturaStr = Console.ReadLine();

                if ((DateTime.TryParseExact(fechaNacimientoStr, "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento) && (DateTime.TryParseExact(fechaFuturaStr, "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaFutura))))
                {
                    Edad edad = CalculaEdad(fechaFutura, fechaNacimiento);
                    if (edad.edadAnios > 0 && edad.edadMeses > 0 && edad.edadDias > 0)
                    {
                        Console.WriteLine($"Su edad seria: {edad.edadAnios} años, {edad.edadMeses} meses y {edad.edadDias} días.");
                    }
                    else
                    {
                        Console.WriteLine("No habias nacido");
                    }

                }
                else
                {
                    Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
                }
            }
            
        }

        private static void caso1()
        {
            Console.WriteLine("***  Calcula edad ***");

            if (formatoAnos())
            {
                Console.Write("Ingrese su fecha de nacimiento (dd/mm/aaaa): ");
                string fechaNacimientoStr = Console.ReadLine();

                if (DateTime.TryParseExact(fechaNacimientoStr, "dd/MM/yyyy", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
                {
                    DateTime fechaActual = DateTime.Now;
                    Edad edad = CalculaEdad(fechaActual, fechaNacimiento);
                    if (edad.edadAnios > 0 && edad.edadMeses > 0 && edad.edadDias > 0)
                    {
                        Console.WriteLine($"Su edad es: {edad.edadAnios} años, {edad.edadMeses} meses y {edad.edadDias} días.");
                    }
                    else
                    {
                        Console.WriteLine("No has nacido todavia");
                    }
                }
                else
                {
                    Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
                }

            } else
            {
                Console.Write("Ingrese su fecha de nacimiento (yyyy/mm/dd): ");
                string fechaNacimientoStr = Console.ReadLine();

                if (DateTime.TryParseExact(fechaNacimientoStr, "yyyy/MM/dd", null, System.Globalization.DateTimeStyles.None, out DateTime fechaNacimiento))
                {
                    DateTime fechaActual = DateTime.Now;
                    Edad edad = CalculaEdad(fechaActual, fechaNacimiento);
                    if (edad.edadAnios > 0 && edad.edadMeses > 0 && edad.edadDias > 0)
                    {
                        Console.WriteLine($"Su edad es: {edad.edadAnios} años, {edad.edadMeses} meses y {edad.edadDias} días.");
                    }
                    else
                    {
                        Console.WriteLine("No has nacido todavia");
                    }
                }
                else
                {
                    Console.WriteLine("Fecha de nacimiento inválida. Asegúrese de seguir el formato dd/mm/aaaa.");
                }

            }

        }

        private static bool formatoAnos()
        {
            Console.WriteLine("Que formato prefieres:");
            Console.WriteLine("[1] dd/mm/aaaa");
            Console.WriteLine("[2] aaaa/mm/dd");
            string preferencia = Console.ReadLine();
            if (preferencia=="1" || preferencia == "[1]")
            {
                return true;
            } else if(preferencia == "2" || preferencia == "[2]") { 
                return false; 
            } else {
                Console.WriteLine("Opcion incorrecta, vuelve a elegir");
                return formatoAnos();
            }
        }
    }
    
    
}