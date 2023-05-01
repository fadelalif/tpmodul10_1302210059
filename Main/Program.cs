using AljabarLibraries;
internal class Program
{
    private static void Main(string[] args)
    {
        double[] persamaan1 = { 1, -3, -10 };
        double[] persamaan2 = { 2, -3 };
        PersamaanKuadrat persamaanKuadrat = new PersamaanKuadrat();

        double[] hasilAkar = persamaanKuadrat.AkarPersamaanKuadrat(persamaan1);
        double[] hasilKuadrat = persamaanKuadrat.HasilKuadrat(persamaan2);

        Console.WriteLine("Hasil akar persamaan kuadrat:");
        foreach (double akar in hasilAkar)
        {
            Console.Write(akar + " ");
        }

        Console.WriteLine("\nHasil kuadrat:");
        foreach (double hasil in hasilKuadrat)
        {
            Console.Write(hasil + " ");
        }

    }
}