using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Domain
{
        public class Agendamento
        {
            public int Id_agendamento { get; set; }
            public DateTime Data { get; set; }
            public string Desc_consulta { get; set; }
            public int Id_paciente { get; set; }
            public int Id_dentista { get; set; }

        public string Show() => $"{Id_agendamento} Data: {Data} Ds Consulta: {Desc_consulta}";

        public Agendamento (int id_agendamento,DateTime data, string desc_consulta,int id_paciente,int id_dentista)
        {
            Id_agendamento = id_agendamento;
            Data = data;
            Desc_consulta = desc_consulta;
            Id_paciente = id_paciente;
            Id_dentista = id_dentista;

        } 


        public Agendamento()
        {

        }



     }
}
