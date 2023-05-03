namespace Nomina_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("********************** \n\tNomina \n**********************");

            //ENTRADA DE DATOS
            Console.WriteLine("¿Desea Imprimir la nomina de los empleados? (S/N)");
            string? resp = Console.ReadLine().ToUpper();

            //ESTRUCTURA SELECTIVA
            switch(resp)
            {
                case "S":
                    Empleados();
                    break;
                case "N":
                    Console.WriteLine("No se ha impreso la nomina de los empleados");
                    break;
                default: Console.WriteLine("Opción no existente");
                    break;
            }

            static void Empleados()
            {
                //VECTORES
                int[] nCorrelativo = {0001,0002,0003,0004,0005,0006,0007,0008,0009,0010};
                string[] nom = {"Ana Torres", "Luisa Aguilar", "Carlos Gomez", "Andres Vargas", "Sofia Medina","Diego Hernandez", "Adriana Colato", "Pablo Mendoza", "Valeria Espinoza", "Marcelo Monge"};
                double[] sueldos = { 1842.35, 1225.09, 1191.43, 817.28, 1125.56, 1032.15, 1542.68, 879.49, 1649.91, 1041.57 };

                //ESTRUCTURA CONTROLADA POR CONTADOR
                for (int i = 0; i < nCorrelativo.Length; i++)
                {
                    //SALIDA DE DATOS
                    Console.WriteLine($"{nCorrelativo[i].ToString("D4")} // {nom[i]} // ${sueldos[i]}");
                }

                //LLAMADO AL METODO SUELDOS
                //NOTA: El metodo Sueldos solo sirve para calcular los porcentajes
                // y la cantidad de personas que ganan cierta cifra en sus sueldos
                Sueldos(sueldos);
            }

            static void Sueldos(double[] suledos)
            {
                //VARIABLES
                int mas1500 = 0, entre850y1500 = 0, menos850 = 0, entre850y1k = 0, mas1k = 0;

                //ESTRUCTURA CONTROLADA POR CONTADOR
                for (int i = 0; i < suledos.Length; i++)
                {
                    if (suledos[i] > 1500) mas1500++;
                    if (suledos[i] > 850 && suledos[i] < 1500) entre850y1500++;    
                    if (suledos[i] < 850) menos850++;
                    if (suledos[i] > 850 && suledos[i] < 1000) entre850y1k++;
                    if (suledos[i] > 1000) mas1k++;

                }

                //VARIABLES DE PROCESO
                double total850 = (menos850 * 100) / 10;
                double totalentre = (entre850y1k * 100) / 10;
                double total1k = (mas1k * 100) / 10;

                //SALIDA DE DATOS
                Console.WriteLine("*********************************** \n\t ESTADISTICAS \n***********************************");
                Console.WriteLine($"{mas1500} empleados ganan mas de $1500");
                Console.WriteLine($"{entre850y1500} empleados ganan entre $850 y $1500");
                Console.WriteLine($"{menos850} empleados ganan menos de $850");
                Console.WriteLine("*****************************************************************************");
                Console.WriteLine($"Hay {menos850} empleados que ganan menos de $850 y representan el {total850}% de la compañia");
                Console.WriteLine($"Hay {entre850y1k} empleados que ganan entre $850 y $1000 y representan el {totalentre}% de la compañia");
                Console.WriteLine($"Hay {mas1k} empleados que ganan mas de $1000 y representan el {total1k}% de la compañia");
            }
        }
    }
}
