using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DEsafio04.Models
{  public class Estacionamento
    {
        private decimal precoInicial = 0;
        private decimal precoPorHora = 0;
        private List<string> veiculos = new List<string>();
        List<string> carro = new List<string>();
        string placa = "";
        string modelo = "";

        public Estacionamento(decimal precoInicial, decimal precoPorHora)
        {
            this.precoInicial = precoInicial;
            this.precoPorHora = precoPorHora;
        }

        public void AdicionarVeiculo()
        {
            // IMPLEMENTADO*
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            placa = Console.ReadLine();
            veiculos.Add(placa);
            Console.WriteLine("Digite o modelo do veículo para estacionar:");
            modelo = Console.ReadLine();
            carro.Add(modelo);


        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");

            // IMPLEMENTADO*
            string placa = Console.ReadLine();
        Console.WriteLine("Digite o modelo do veículo para remover:");

            string modelo =  Console.ReadLine();

            // Verifica se o veículo existe
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");

                // IMPLEMENTADO
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = 0;
                valorTotal = precoInicial +(horas*precoPorHora); 

                // IMPLEMENTADO
                veiculos.Remove(placa);
                carro.Remove(modelo);


                Console.WriteLine($"O veículo modelo {modelo} e {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                // IMPLEMENTADO
                for(int i = 0; i<veiculos.Count ;i++){
                    Console.WriteLine($" Veículo  modelo {carro[i]} e placa {veiculos[i]} está na vaga {i+1}");
                }
            
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }
    }
}
  