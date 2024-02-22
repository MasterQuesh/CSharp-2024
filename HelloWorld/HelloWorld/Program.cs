//Módulos ou pacotes

using System;
//c# capaz de manipular coisas do sistema operacional do usuário
using System.Collections.Generic;
using System.Linq;
//ferramenta para lidar com um grande conjunto de dados
using System.Text;
//permite a manipulação de textos

namespace HelloWorld
{
//inicio do programa
    internal class Program
    {
      
        static void Main(string[] args)
        {
            //função principal / método inicial
            //tudo dentro do main é executado assim que o programa for aberto
            Console.WriteLine("Hello World!");
            // /Write exibe uma mensagem na tela
            // /WriteLine exibe uma mensagem com quebra de linha
            Console.WriteLine("Meu nome é Pedro");
            Console.ReadLine();
            //se o comando Write existir, utilizar o comando Read para detectar o que o usuário escreveu no console
            //comando que espera o usuário pressionar Enter

        }
    }
}

//fim do programa
