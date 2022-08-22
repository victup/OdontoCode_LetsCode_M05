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

    }
}
