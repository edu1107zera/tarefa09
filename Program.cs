using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa09
{
    class Program
    {
        static List<string> vagas = new List<string> { "___", "___", "___", "___", "___", };
        static void Main(string[] args)
        {
            
            int posicao= 0;
            int escolha;
            Console.WriteLine("1- estacionar");
            Console.WriteLine("2- retirar veiculo");
            Console.WriteLine("3- listar veiculos");
            escolha = int.Parse(Console.ReadLine());

            if(escolha == 1)
            {
                Console.Write("Qual a posiçao que deseja estacionar? ");
                posicao =int.Parse(Console.ReadLine());
                Console.Write("\nDigite a placa do seu carro: ");
                string placa = Console.ReadLine();
                vagas[posicao] = placa;
                Console.WriteLine("VEICULOS ESTACINADO COM SUCESSO");
                Main(null);
            }  
            
            if(escolha == 2)
            {
                Console.WriteLine("Qual a placa do carro que gostaria de retirar: ");
                string placa =Console.ReadLine();
                int contador = 0;

                while (contador < vagas.Count)
                {
                    if(vagas[contador] == placa)
                    {
                        vagas[contador] = "___";
                        Console.WriteLine("retirado");
                        break;
                    }
                    contador++;
                }

                Main(null);
            }

            if (escolha == 3) { 
                int contador1 = 0;
                while (contador1 < vagas.Count)
                {
                 Console.WriteLine("nomes:" + vagas[contador1]);
                 contador1++;
                }
                Console.ReadKey();
                Main(null);
            }

        }
    }
}
