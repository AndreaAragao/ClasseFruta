using Projeto04.Entidade;
using System;

namespace Projeto04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Fruta fruta1 = new Fruta();
            fruta1.Nome = "morango";
            fruta1.Cor = "vermelho";
            fruta1.Tamanho = 10;

            Fruta fruta2;
            fruta2 = new Fruta();
            fruta2.Nome = "cupuacu";
            fruta2.Cor = "amarelo";
            fruta2.Tamanho = 30;

            Fruta fruta3;
            fruta3 = new Fruta();
            fruta3.Nome = "manga";
            fruta3.Cor = "amarela";
            fruta3.Tamanho = 25;

            Fruta fruta4= new Fruta();
            fruta4.Nome = "kiwi";
            fruta4.Cor = "verde";
            fruta4.Tamanho = 7;




        }
    }
}
