using System;

namespace ProgramacionOrientadaAObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            clsClientesBase cliente = new clsClientesBase(0, "Juan Carlos Cuéllar Ruz", "001", "CURJ721119KY9", 1, "Juan Carlos Cuéllar Ruz");

            Console.WriteLine(cliente.Clave + "-" + cliente.Nombre);
            Console.WriteLine(cliente.TipoRegimen);
            Console.WriteLine(cliente.RFC);
            Console.ReadKey();
        }
    }
}
