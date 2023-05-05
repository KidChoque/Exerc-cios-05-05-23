using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ex_1
{
    public class Elevador
    {
        // FL=Floor
        // Terréo = 0
        public int ActualFL { get; set; }
        public int NumberOfFL {get;set;}
        public int CapacityPeople { get; set; }
        
        public int Passengers { get; set; }

        public bool Entrou { get; set; }


        public void Inicialize(int CapacityPeople, int NumberOfFL)
        {
            Console.WriteLine($"Capacidade de passageiros = {CapacityPeople}");
            Console.WriteLine($"");
            Console.WriteLine($"Andares = {NumberOfFL}");

        }

        public bool Entrar(int CapacityPeople, int Passengers)
        {
            bool Entrou;
            if (CapacityPeople > Passengers)
            {
                Entrou = true;
                Console.WriteLine($"Sempre cabe mais um. Seja Bem vindo ao nosso elevador");
                Console.WriteLine($"");               
                Console.WriteLine($"O número de passageiros é = {Passengers + 1}");
                
            }
            else
            {
                Entrou = false;
                Console.WriteLine($"O limite de passageiros se excedeu");
               
            }
            return Entrou;


        }

        public int Subir(int ActualFL,int NumberOfFL)
        {
            if (ActualFL < NumberOfFL)
            {
                Console.WriteLine($"Subindo ! ");
                Console.WriteLine($"O andar é {NumberOfFL + 1}");
                
                
            }
            return ActualFL;
        }

        public int Sair(int Passengers)
        {
            if (Passengers != 0)
            {
                Console.WriteLine($" Número de passageiros = {Passengers - 1}");
                
            }
            return Passengers;
        }

        public int Descer(int ActualFL, int NumberOfFL)
        {
            return 0;
        }


    }
}