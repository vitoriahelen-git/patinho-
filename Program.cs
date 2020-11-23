using System;

namespace patinho_
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero; 

            Console.Write("Quantos patinhos?: "); 
            numero = Convert.ToInt32(Console.ReadLine()); 
            

            for (int x = numero; x>0; x--)
            {
                Console.WriteLine($"{x} patinhos foram passear\nÁlem das monstanhas\nPara brincar\nA mamãe gritou: Quá, quá, quá, quá\nMas so {x-1} voltarem de lá.\n");
            }
            {
                Console.WriteLine($"A mamãe patinha foi procurar\nAlém das montanhas\nNa beira do mar\nA mamãe gritou: Quá, quá, quá, quá\nE os {numero} patinhos voltaram de lá.  ");
            }
        }
    }
}
