namespace actividadIUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int CantidadPersonas = 0, edadP;
            bool valid = false, Comp = false;
            string Nombrepersona;

            Console.WriteLine("Bienvenido");

            do
            {
                Console.Write("Ingresa la cantidad de personas: ");
                valid = int.TryParse(Console.ReadLine(), out CantidadPersonas);

                if (!valid || CantidadPersonas <= 0)
                {
                    Console.WriteLine("Ingrese un número válido mayor o igual a cero.");
                    valid = false; 
                }
            } while (!valid);


            if (CantidadPersonas == 1)
            {
                Console.Write("Ingrese el nombre de la persona: ");
                Nombrepersona = Console.ReadLine();

                do
                {
                    Console.Write("Ingrese la edad de la persona: ");
                    Comp = int.TryParse(Console.ReadLine(), out edadP);

                    if (!Comp || edadP <= 0)
                    {
                        Console.WriteLine("Ingrese un número valido y mayor a cero");
                        Comp = false;
                    }
                } while (!Comp);

                if (edadP < 18)
                {

                    Console.WriteLine("El nombre de la persona es " + Nombrepersona + " y su edad es " + edadP + " por lo tanto es menor de edad");

                }

                else
                {

                    Console.WriteLine("El nombre de la persona es " + Nombrepersona + " y su edad es " + edadP + ", por lo tanto es mayor de edad");

                }

            }

            else
            {
                List<int> edadPmenores = new List<int>();
                List<int> edadGen = new List<int>();
                List<int> edadPmayores = new List<int>();
                List<string> NombrePmayores = new List<string>();
                List<string> NombrePmenores = new List<string>();
                List<string> NombreGen = new List<string>();

                for (int i = 1; i <= CantidadPersonas; i++)
                {

                    Console.Write("Ingresa el nombre de la persona " + i + " : ");
                    Nombrepersona = Console.ReadLine();
                    Comp = false;

                    do
                    {

                        Console.Write("Ingrese la edad de la persona " + i + " : ");
                        Comp = int.TryParse(Console.ReadLine(), out edadP);

                        if (!Comp || edadP <= 0)
                        {
                            Console.WriteLine("Ingrese un número valido y mayor a cero");
                            Comp = false;
                        }
                    } while (!Comp);

                    edadGen.Add(edadP);
                    NombreGen.Add(Nombrepersona);

                    if (edadP < 18)
                    {

                        edadPmenores.Add(edadP);
                        NombrePmenores.Add(Nombrepersona);

                    }
                    else
                    {

                        edadPmayores.Add(edadP);
                        NombrePmayores.Add(Nombrepersona);

                    }

                }

                Console.WriteLine("Nombre y edades de la lista general");

                for (int i = 0; i < edadGen.Count; i++)
                {

                    Console.WriteLine(NombreGen[i] + " ----> " + edadGen[i]);

                }

                Console.WriteLine("Edades y nombres personas menores");

                for (int i = 0; i < edadPmenores.Count; i++)
                {

                    Console.WriteLine(NombrePmenores[i] + " ----> " + edadPmenores[i]);

                }
                Console.WriteLine("Edades y nombres personas mayores");

                for (int i = 0; i < edadPmayores.Count; i++)
                {

                    Console.WriteLine(NombrePmayores[i] + " ----> " + edadPmayores[i]);

                }
            }
        }
    }
}
