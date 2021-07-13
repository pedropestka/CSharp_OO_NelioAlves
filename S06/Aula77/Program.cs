using System;
using System.Collections.Generic; // necessário para trabalhar com listas

namespace Aula78_Listas
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Criaçao e instanciaçao da uma uma lista chamada 'list'
            List<string> list = new List<string>();

            // adicionar valores de forma sequencial
            list.Add("Maria");
            list.Add("Alex");
            list.Add("Bob");
            list.Add("Anna");

            // adicionar valores em uma posiçao especifica
            list.Insert(2, "Marco");

            // percorrer cada elemento da lista e imprimi-lo
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // tamanho da lista
            Console.WriteLine("List count: " + list.Count);

            // primeiro elemento da lista que começa com A
            string s1 = list.Find(x => x[0] == 'A');
            Console.WriteLine("First 'A': " + s1);

            // ultimo elemento da lista que comeca com a  A
            string s2 = list.FindLast(x => x[0] == 'A');
            Console.WriteLine("Last 'A': " + s2);

            // posiçao do primeiro que começa com A
            int pos1 = list.FindIndex(x => x[0] == 'A');
            Console.WriteLine("First position 'A': " + pos1);

            // posiçao do ultimo que começa com A
            int pos2 = list.FindLastIndex(x => x[0] == 'A');
            Console.WriteLine("Last position 'A': " + pos2);

            // cria uma sub lista com base em um critério
            // aqui o filtro é dos que possuem exatamente 5 caracteres
            List<string> list2 = list.FindAll(x => x.Length == 5);
            Console.WriteLine("---------------------");

            // percorre a sub-lista e imprime os elementos
            foreach (string obj in list2)
            {
                Console.WriteLine(obj);
            }

            // remover elemento 'Alex'
            list.Remove("Alex");
            Console.WriteLine("---------------------");

            // imprime lista
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }

            // remove itens que começa com 'M'
            list.RemoveAll(x => x[0] == 'M');
            Console.WriteLine("---------------------");

            // imprime lista
            foreach (string obj in list)
            {
                Console.WriteLine(obj);
            }


            Console.ReadLine();
        }
    }
}
