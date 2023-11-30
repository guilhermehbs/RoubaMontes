﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrabalhoAED
{
    class Program
    {
        static void Main(string[] args)
        {
            Jogo jogo = new Jogo();

            Console.Write("Digite a quantidade de jogadores: ");
            int qntJogadores = int.Parse(Console.ReadLine());
            Console.Write("Digite a quantidade de baralhos a serem utilizados na partida: ");
            int qntBaralhos = int.Parse(Console.ReadLine());

            jogo.ComecarJogo(qntJogadores, qntBaralhos);
            

            CriarCarta();

        }

        static void CriarCarta()
        {
            Console.WriteLine(new String('*', 10));
            Console.WriteLine("*" + " 4" + new String(' ', 6) + "*");
            Console.WriteLine("*" + " " + new String('*', 6) + " " + "*");
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("*" + " " + "*" + new String(' ', 4) + "*" + " " + "*");

            }
            Console.WriteLine("*" + " " + new String('*', 6) + " " + "*");
            Console.WriteLine("*" + new String(' ', 6) + "4 " + "*");
            Console.WriteLine(new String('*', 10));
        }
    }
}
