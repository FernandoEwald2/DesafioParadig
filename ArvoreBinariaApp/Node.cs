namespace ArvoreBinariaApp
{
    using System;
    using System.Linq;

    public class Node
    {
        public int Valor;
        public Node Esquerda;
        public Node Direita;

        public Node(int valor)
        {
            Valor = valor;
            Esquerda = null;
            Direita = null;
        }
    }

    

}
