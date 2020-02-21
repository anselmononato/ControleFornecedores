

using System;

namespace Program
{
    public class cidade
    {
        public string nome { get; set; }
        public casa casas { get; set; }
        public cidade(string nome, casa casas)
        {
            this.nome = nome;
            this.casas = casas;
        }
    }

    public class casa
    {
        public string dono { get; set; }
        public string cor { get; set; }
        public casa(string dono, string cor)
        {
            this.dono = dono;
            this.cor = cor;
        }

    }

    public class Program
    {
        public static void Main(string[] args)
        {
            casa[] casas = new casa[2];
            casa casa1 = new casa("João", "verde");
            casa casa2 = new casa("José", "vermelha");
            casas[0] = casa1;
            casas[1] = casa2;
            cidade cidade1 = new cidade("Lisboa", casas[0]);
            cidade cidade2 = new cidade("Porto", casas[1]);


            Console.WriteLine(cidade1.casas.dono); //João


        }
    }
}


/*
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace TesteAcessors
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
//            Pessoa p = new Pessoa("Anselmo", 28);


//        }
    
//    }


//    class Pessoa
//    {
//        public string nome { set; get; }
//        public int idade { set; get; }

//        public Pessoa(string nome, int idade)
//        {
//            this.nome = nome;
//            this.idade = idade;
//        }


//    }

//}
*/
