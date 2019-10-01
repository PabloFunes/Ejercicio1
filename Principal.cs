using System;


namespace Ejercicio1
{
    class Principal
    {
        static void Main(string[] args)
        {
            CalculadoraDeAreas Areas = new CalculadoraDeAreas();
            bool Band = true;
            do
            {
                Console.WriteLine("1.- Para el Cuadrado");
                Console.WriteLine("2.- Para el Circulo");
                Console.WriteLine("3.- Para el Triangulo");
                Console.WriteLine("4.- Para el Rectangulo");
                int SeleccionArea = Convert.ToInt32(Console.ReadLine());
                switch (SeleccionArea)
                {
                    case 1:
                        Console.WriteLine("INDICA EL TAMAÑO DE UN LADO");
                        var Lado = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Areas.AreaCuadrado(Lado));
                        break;
                    case 2:
                        Console.WriteLine("INDICA EL TAMAÑO DE LA CIRCUNFERENCIA");
                        var Circunf = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Areas.AreaCirculo(Circunf));
                        break;

                    case 3:
                        Console.WriteLine("INDICA EL TAMAÑO DE LA BASE DEL TRIANGULO");
                        var BaseTriangulo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("INDICA EL TAMAÑO DE LAALTURA DEL TRIANGULO");
                        var AlturaTriang = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Areas.AreaTriangulo(BaseTriangulo, AlturaTriang));
                        break;

                    case 4:
                        Console.WriteLine("INDICA EL TAMAÑO DE LA BASE DEL RECTANGULO");
                        var BaseTriang = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("INDICA EL TAMAÑO DE LA ALTURA DEL RECTANGULO");
                        var AlturaTriangulo = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(Areas.AreaRectangulo(BaseTriang, AlturaTriangulo));
                        break;

                    default:
                        Console.WriteLine("OPCION INVALIDA");
                        break;
                }
                Console.WriteLine("¿DESEAS CONTINUAR?");
                Console.WriteLine(" SÍ - 1");
                Console.WriteLine(" NO - 2");
                int aux = Convert.ToInt32(Console.ReadLine());
                if (aux == 2)
                    Band = false;
            } while (Band != false);
        }
    }
}
