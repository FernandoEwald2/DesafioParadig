using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArvoreBinariaApp
{
    public class ArvoreBinaria
    {
        public static Node ConstruirArvore(int[] nums)
        {
            if (nums == null || nums.Length == 0)
                return null;

            int max = nums.Max();
            int idx = Array.IndexOf(nums, max);
            Node raiz = new Node(max);

            int[] esquerda = nums.Take(idx).OrderByDescending(x => x).ToArray();
            int[] direita = nums.Skip(idx + 1).OrderByDescending(x => x).ToArray();

            raiz.Esquerda = ConstruirGalho(esquerda, true);  // galho esquerdo
            raiz.Direita = ConstruirGalho(direita, false);    // galho direito

            return raiz;
        }

        // flag: true = galho esquerdo (liga com .Esquerda), false = galho direito (liga com .Direita)
        private static Node ConstruirGalho(int[] valores, bool esq)
        {
            if (valores.Length == 0)
                return null;

            Node raiz = new Node(valores[0]);
            Node atual = raiz;

            for (int i = 1; i < valores.Length; i++)
            {
                Node novo = new Node(valores[i]);
                if (esq)
                    atual.Esquerda = novo;    // conecta filho à esquerda para galho esquerdo
                else
                    atual.Direita = novo;     // conecta filho à direita para galho direito

                atual = novo;
            }

            return raiz;
        }


        public static void Imprimir(Node node, string prefixo = "", string lado = "Raiz")
        {
            if (node == null) return;

            Console.WriteLine($"{prefixo}[{lado}] -> {node.Valor}");
            Imprimir(node.Esquerda, prefixo + "  ", "E");
            Imprimir(node.Direita, prefixo + "  ", "D");
        }
    }
}
