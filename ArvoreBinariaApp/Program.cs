using ArvoreBinariaApp;

class Program
{
    static void Main()
    {
        int[] exemplo1 = { 3, 2, 1, 6, 0, 5 };
        int[] exemplo2 = { 7, 5, 13, 9, 1, 6, 4 };

        Console.WriteLine("Árvore 1:");
        var arvore1 = ArvoreBinaria.ConstruirArvore(exemplo1);
        ArvoreBinaria.Imprimir(arvore1);

        Console.WriteLine("\nÁrvore 2:");
        var arvore2 = ArvoreBinaria.ConstruirArvore(exemplo2);
        ArvoreBinaria.Imprimir(arvore2);
    }
}
