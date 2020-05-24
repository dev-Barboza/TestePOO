using System; //EXIBIR OU ARMAZENAR MENSAGEM OU DADOS  (FUNCIONALIDADE)

namespace _01Conceitos // É A PASTA ONDE TEM O PROJETO
{
    class Program
    {
        private const int V = 16;

        static void Main(string[] args)//TODO PROJETO EM C# TERA ISSO,É O ARQUIVO PRINCIPAL. sO PODE TER 1 
        {
            //instanciar um objeto
            Pessoa obj = new Pessoa();//nome da pessoa é obj
            obj.nome="Matheus";
            obj.idade = 15;
            obj.mensagem();
        }
    }
}