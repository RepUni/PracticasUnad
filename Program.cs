using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {



            //  tipoDeValor();
            // numPareImpar();
            //  mayorDeEdad();
            //  multiploDe5();
            // DescuentoPorEdad();
            // calificacionAprovatoria();
            // diaDeLaSemana();
            // numMayorEntreDos();
            // numMayorEntreTres();
            //  ClasificacionDeAngulos();
            //  calculosImpuestos();
            //  ClasificacionDeNumeros();
            //  verificaciónDeAñoBisiesto();
            //  conversionDeCalificaciones();
            //  comparacionDeTresLongitudes();
            //  calculadoraDeDescuentos();
            //    tipoDeTriangulo();
            //   evaluacionDeTemperatura();
            //    conversacionDeHorasAminutos();
            //             imc();



        }

        static void tipoDeValor()
        {
            //Primer programa 

            Console.WriteLine("Ingrese un valor ");

            double valor = double.Parse(Console.ReadLine());

            if (valor > 0)
            {
                Console.WriteLine("El valor es positivo");
            }
            else if (valor < 0)
            {
                Console.WriteLine("El valor es negativo");
            }
            else
            {

                Console.WriteLine("El numero es igual a 0");
            }
        }
        static void numPareImpar()
        {
            Console.WriteLine("Ingrese un valor");
            double num = double.Parse(Console.ReadLine());

            if (num%2 == 0) {
                Console.WriteLine("El numero es par");
            }
            else
            {
                Console.WriteLine("El numero es impar");
            }

        }
        static void mayorDeEdad()
        {
            Console.Write("Introduce tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Eres mayor de edad.");
            }
            else
            {
                Console.WriteLine("Eres menor de edad.");
            }
        }

        static void multiploDe5()
        {
            Console.Write("Introduce un número entero: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 5 == 0)
            {
                Console.WriteLine(numero + " es múltiplo de 5.");
            }
            else
            {
                Console.WriteLine(numero + " no es múltiplo de 5.");
            }

        }
        static void DescuentoPorEdad()
        {
            Console.Write("Introduce tu edad: ");
            int edad = int.Parse(Console.ReadLine());

            if (edad > 60)
            {
                Console.WriteLine("¡Felicidades! Aplica para el descuento del 50%.");
            }
            else
            {
                Console.WriteLine("Lo sentimos, no aplica para el descuento.");
            }
        }
        static void calificacionAprovatoria()
        {
            Console.Write("Introduce la calificación del estudiante (0-100): ");
            int calificacion = int.Parse(Console.ReadLine());

            if (calificacion >= 60)
            {
                Console.WriteLine("¡Aprobado!");
            }
            else
            {
                Console.WriteLine("Reprobado.");
            }
        }

        static void diaDeLaSemana()
        {
            Console.Write("Introduce un número del 1 al 7: ");
            int numeroDia = int.Parse(Console.ReadLine());

            string diaSemana;

            switch (numeroDia)
            {
                case 1:
                    diaSemana = "Domingo";
                    break;
                case 2:
                    diaSemana = "Lunes";
                    break;
                case 3:
                    diaSemana = "Martes";
                    break;
                case 4:
                    diaSemana = "Miercoles";
                    break;
                case 5:
                    diaSemana = "Jueves";
                    break;
                case 6:
                    diaSemana = "Viernes";
                    break;
                case 7:
                    diaSemana = "Sabado";
                    break;
                default:
                    diaSemana = "Número inválido";
                    break;
            }

            Console.WriteLine("El día de la semana es: " + diaSemana);
        }
        static void numMayorEntreDos()

        {
            Console.Write("Introduce el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine("El primer número (" + numero1 + ") es mayor.");
            }
            else if (numero2 > numero1)
            {
                Console.WriteLine("El segundo número (" + numero2 + ") es mayor.");
            }
            else
            {
                Console.WriteLine("Los números son iguales.");
            }

        }
        static void numMayorEntreTres()
        {

            Console.Write("Introduce el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());

            int mayor = numero1; 

            if (numero2 > mayor)
            {
                mayor = numero2;
            }

            if (numero3 > mayor)
            {
                mayor = numero3;
            }

            Console.WriteLine("El número mayor es: " + mayor);
        }

        static void ClasificacionDeAngulos()
        {
            Console.Write("Introduce el valor del ángulo en grados: ");
            double angulo = double.Parse(Console.ReadLine());

            if (angulo < 90)
            {
                Console.WriteLine("El ángulo es agudo.");
            }
            else if (angulo == 90)
            {
                Console.WriteLine("El ángulo es recto.");
            }
            else if (angulo > 90 && angulo < 180)
            {
                Console.WriteLine("El ángulo es obtuso.");
            }
            else if (angulo == 180)
            {
                Console.WriteLine("El ángulo es llano.");
            }
            else
            {
                Console.WriteLine("El ángulo es mayor a 180°");
            }
        }
        static void calculosImpuestos()
        {
            Console.Write("Introduce tu salario mensual: ");
            double salario = double.Parse(Console.ReadLine());

            double impuestos = 0;

            if (salario < 10000)
            {
                impuestos = 0;
            }
            else if (salario >= 10000 && salario <= 30000)
            {
                impuestos = salario * 0.10; // 10% de impuestos
            }
            else
            {
                impuestos = salario * 0.20; // 20% de impuestos
            }

            Console.WriteLine("Los impuestos a pagar son: " + impuestos);
        }
        static void ClasificacionDeNumeros()
        {
            Console.Write("Introduce el primer número: ");
            int numero1 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el segundo número: ");
            int numero2 = int.Parse(Console.ReadLine());

            Console.Write("Introduce el tercer número: ");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 > 0 && numero2 > 0 && numero3 > 0)
            {
                Console.WriteLine("Todos los números son positivos.");
            }

            if (numero1 < 0 && numero2 < 0 && numero3 < 0)
            {
                Console.WriteLine("Todos los números son negativos.");
            }

            if (numero1 == 0 || numero2 == 0 || numero3 == 0)
            {
                Console.WriteLine("Hay al menos un cero entre los números.");
            }

            if ((numero1 > 0 && numero2 < 0) || (numero1 > 0 && numero3 < 0) || (numero2 > 0 && numero1 < 0) || (numero2 > 0 && numero3 < 0) || (numero3 > 0 && numero1 < 0) || (numero3 > 0 && numero2 < 0))
            {
                Console.WriteLine("Los números son mixtos (positivos y negativos).");
            }
        }

        static void verificaciónDeAñoBisiesto()
        {
            Console.Write("Introduce un año: ");
            int anio = int.Parse(Console.ReadLine());

            if ((anio % 4 == 0 && anio % 100 != 0) || anio % 400 == 0)
            {
                Console.WriteLine(anio + " es un año bisiesto.");
            }
            else
            {
                Console.WriteLine(anio + " no es un año bisiesto.");
            }
        }
        static void conversionDeCalificaciones()
        {
            Console.Write("Introduce la calificación numérica del estudiante (0-100): ");
            int calificacion = int.Parse(Console.ReadLine());

            string calificacionLetra;

            if (calificacion >= 90 && calificacion <= 100)
            {
                calificacionLetra = "A";
            }
            else if (calificacion >= 80 && calificacion <= 89)
            {
                calificacionLetra = "B";
            }
            else if (calificacion >= 70 && calificacion <= 79)
            {
                calificacionLetra = "C";
            }
            else if (calificacion >= 60 && calificacion <= 69)
            {
                calificacionLetra = "D";
            }
            else if (calificacion >= 0 && calificacion <= 59)
            {
                calificacionLetra = "F";
            }
            else
            {
                calificacionLetra = "Calificación inválida";
            }

            Console.WriteLine("La calificación en letra es: " + calificacionLetra);
        }
        static void comparacionDeTresLongitudes()
        {
            Console.Write("Introduce la primera longitud: ");
            double lado1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce la segunda longitud: ");
            double lado2 = double.Parse(Console.ReadLine());

            Console.Write("Introduce la tercera longitud: ");
            double lado3 = double.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 && lado1 + lado3 > lado2 && lado2 + lado3 > lado1)
            {
                Console.WriteLine("Las longitudes pueden formar un triángulo.");
            }
            else
            {
                Console.WriteLine("Las longitudes no pueden formar un triángulo.");
            }
        }

        static void calculadoraDeDescuentos()
        {
            Console.Write("Introduce el precio del producto: $");
            double precio = double.Parse(Console.ReadLine());

            double descuento = 0;

            if (precio >= 50 && precio <= 100)
            {
                descuento = precio * 0.05; // 5% de descuento
            }
            else if (precio > 100)
            {
                descuento = precio * 0.10; // 10% de descuento
            }

            double precioFinal = precio - descuento;

            Console.WriteLine("Descuento aplicado: $" + descuento);
            Console.WriteLine("Precio final: $" + precioFinal);
        }
        static void tipoDeTriangulo()
        {
            Console.Write("Introduce la primera longitud: ");
            double lado1 = double.Parse(Console.ReadLine());

            Console.Write("Introduce la segunda longitud: ");
            double lado2 = double.Parse(Console.ReadLine());

            Console.Write("Introduce la tercera longitud: ");
            double lado3 = double.Parse(Console.ReadLine());

            if (lado1 == lado2 && lado2 == lado3)
            {
                Console.WriteLine("El triángulo es equilátero.");
            }
            else if (lado1 == lado2 || lado1 == lado3 || lado2 == lado3)
            {
                Console.WriteLine("El triángulo es isósceles.");
            }
            else
            {
                Console.WriteLine("El triángulo es escaleno.");
            }
        }
        static void evaluacionDeTemperatura()
        {
            Console.Write("Introduce la temperatura en grados Celsius: ");
            double temperatura = double.Parse(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.WriteLine("Hace mucho frío");
            }
            else if (temperatura >= 0 && temperatura <= 20)
            {
                Console.WriteLine("Clima fresco");
            }
            else if (temperatura >= 21 && temperatura <= 30)
            {
                Console.WriteLine("Clima agradable");
            }
            else
            {
                Console.WriteLine("Hace mucho calor");
            }
        }

        static void conversacionDeHorasAminutos()
        {
            Console.Write("Introduce la temperatura en grados Celsius: ");
            double temperatura = double.Parse(Console.ReadLine());

            if (temperatura < 0)
            {
                Console.WriteLine("Hace mucho frío");
            }
            else if (temperatura >= 0 && temperatura <= 20)
            {
                Console.WriteLine("Clima fresco");
            }
            else if (temperatura >= 21 && temperatura <= 30)
            {
                Console.WriteLine("Clima agradable");
            }
            else
            {
                Console.WriteLine("Hace mucho calor");
            }
        }
        static void imc()
        {
            Console.Write("Introduce tu peso en kilogramos: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Introduce tu altura en metros: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("Tu IMC es: " + imc.ToString("F2")); // Formatear a 2 decimales

            if (imc < 18.5)
            {
                Console.WriteLine("Bajo peso");
            }
            else if (imc >= 18.5 && imc <= 24.9)
            {
                Console.WriteLine("Peso normal");
            }
            else if (imc >= 25 && imc <= 29.9)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidad");
            }

        }


    }
}
