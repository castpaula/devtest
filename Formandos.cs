using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseClasses
{  
    //DECLARAÇÃO DO TIPO DE DADOS ENUMERADO PARA ESTADO CIVIL:
    public enum EstadoCivil { Solteiro, Casado, Viuvo, Divorciado };
    //DECLARAÇÃO DA CLASSE FORMANDO

    public class Formando : RecursosHumanos
       
    {
        public EstadoCivil EstadoCivil; //public string EstadoCivil; // ENUMERADO?!?!?!?
        public bool ProntoPagamento;
        public bool Empresa;
        public static List<Formando> ListaDeFormandos = new List<Formando>();

        public DateTime DataNascimento { get; private set; }

        public static Formando CriarFormando()
        {
            Formando novo = new Formando();

            Console.WriteLine("Qual o Id?");
            novo.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o Nome?");
            novo.Nome = Console.ReadLine();
            Console.WriteLine("Qual a Data de Nascimento?");
            novo.DataNascimento = DateTime.Parse(Console.ReadLine());

            ListaDeFormandos.Add(novo);

            return novo;
        }

        public static void ListarFormandos()
        {
            foreach (Formando elemento in ListaDeFormandos)
            {
                Console.WriteLine("Id: " + elemento.Id);
                Console.WriteLine("Nome: " + elemento.Nome);
                Console.WriteLine("Nascimento: " + elemento.DataNascimento);
            }
        }
    }
}
