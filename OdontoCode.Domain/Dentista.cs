using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Domain
{
    public class Dentista
    {
        public int Id_dentista { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string CRO { get; set; }
        public string Telefone { get; set; }
        public bool Ativo { get; set; } = true;

        public Dentista(int id_dentista, string nome, string cPF, string cRO, string telefone, bool ativo)
        {
            Id_dentista = id_dentista;
            Nome = nome;
            CPF = cPF;
            CRO = cRO;
            Telefone = telefone;
            Ativo = ativo;
        }

        public Dentista()
        {

        }
    }
}
