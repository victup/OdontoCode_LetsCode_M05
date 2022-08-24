using OdontoCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace OdontoCode.Domain
{

    public class Paciente
    {
        public int Id_paciente { get; set; } 
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Telefone { get; set; }
        public string CEP { get; set; }
        public string UF { get; set; }
        public string Cidade { get; set; }
        public string Bairro { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public bool Ativo { get; set; } = true;

        public Paciente(int id_paciente, string nome, string cPF, string telefone, string cEP, string uF, string cidade, string bairro, string rua, int numero, bool ativo)
        {
            Id_paciente = id_paciente;
            Nome = nome;
            CPF = cPF;
            Telefone = telefone;
            CEP = cEP;
            UF = uF;
            Cidade = cidade;
            Bairro = bairro;
            Rua = rua;
            Numero = numero;
            Ativo = ativo;
        }

        public Paciente()
        {

        }

    } 

}

