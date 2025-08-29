using System.ComponentModel.Design;

internal class Program
{
    private static void main(string[] args)
    {
        //    Console.WriteLine("Complejidad de algoritmo ");
        //    Console.WriteLine("complejidad big 0(1) ");

        //    var nombres = new List<int>() { "ileny","andrea", };

        //    var primero = (List<string> arreglo)=> arreglo != null && arreglo.Count > 0 ?

        //        arreglo[0] : "lista vacia";


        //    Console.WriteLine(primero(nombres));


        System.Console.WriteLine("Com´plejidad Big O(1)");
        var numeros = new List<int>() { 45, 22, 53,500,2000, 1000,0,1};
        var numeroMayor = (List<int> arreglo) =>
        {
            if (arreglo == null || arreglo.Count == 0) {
                return 0;
            }

            int mayor = arreglo[0];
            for (int i = 1; i < arreglo.Count; i++)
            {
                if (arreglo[i] == mayor)
                {
                    mayor = i;
                }
            }
            return mayor;
        };
        int may = numeroMayor(numeros);
        Console.WriteLine("el numero mayor es :" +may);



        Console.ReadKey();
    }
}