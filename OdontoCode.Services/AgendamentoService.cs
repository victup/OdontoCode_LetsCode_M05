using OdontoCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services
{
    public class AgendamentoService
        
    {

            private static List<Agendamento> listaAgendamento = new()
            {
                new Agendamento{Id_agendamento = 1, Data = Convert.ToDateTime("2022-08-05T10:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 1, Id_dentista = 1},
                new Agendamento{Id_agendamento = 2, Data = Convert.ToDateTime("2022-08-06T10:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 2, Id_dentista = 1},
                new Agendamento{Id_agendamento = 3, Data = Convert.ToDateTime("2022-08-05T10:00:00"), Desc_consulta = "EXTRAÇÃO DE SISO", Id_paciente = 3, Id_dentista = 2},
                new Agendamento{Id_agendamento = 4, Data = Convert.ToDateTime("2022-08-05T08:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 4, Id_dentista = 1},
                new Agendamento{Id_agendamento = 5, Data = Convert.ToDateTime("2022-08-06T08:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 5, Id_dentista = 1},
                new Agendamento{Id_agendamento = 6, Data = Convert.ToDateTime("2022-08-06T14:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 6, Id_dentista = 1},
                new Agendamento{Id_agendamento = 7, Data = Convert.ToDateTime("2022-08-06T16:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 7, Id_dentista = 1},
                new Agendamento{Id_agendamento = 8, Data = Convert.ToDateTime("2022-08-06T08:00:00"), Desc_consulta = "CANAL", Id_paciente = 8, Id_dentista = 3},
                new Agendamento{Id_agendamento = 9, Data = Convert.ToDateTime("2022-08-06T10:00:00"), Desc_consulta = "PERIODONTIA", Id_paciente = 9, Id_dentista = 3},
                new Agendamento{Id_agendamento = 10, Data = Convert.ToDateTime("2022-08-07T08:00:00"), Desc_consulta = "CIRURGIA", Id_paciente = 10, Id_dentista = 2},
                new Agendamento{Id_agendamento = 11, Data = Convert.ToDateTime("2022-08-07T10:00:00"), Desc_consulta = "BOTOX", Id_paciente = 11, Id_dentista = 2},
                new Agendamento{Id_agendamento = 12, Data = Convert.ToDateTime("2022-08-05T08:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 12, Id_dentista = 4},
                new Agendamento{Id_agendamento = 13, Data = Convert.ToDateTime("2022-08-06T08:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 13, Id_dentista = 4},
                new Agendamento{Id_agendamento = 14, Data = Convert.ToDateTime("2022-08-06T14:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 14, Id_dentista = 4},
                new Agendamento{Id_agendamento = 15, Data = Convert.ToDateTime("2022-08-07T14:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 15, Id_dentista = 4},
                new Agendamento{Id_agendamento = 16, Data = Convert.ToDateTime("2022-08-05T08:00:00"), Desc_consulta = "CIRURGIA", Id_paciente = 16, Id_dentista = 5},
                new Agendamento{Id_agendamento = 17, Data = Convert.ToDateTime("2022-08-06T10:00:00"), Desc_consulta = "BOTOX", Id_paciente = 17, Id_dentista = 5},
                new Agendamento{Id_agendamento = 18, Data = Convert.ToDateTime("2022-08-06T10:00:00"), Desc_consulta = "EXTRAÇÃO DE SISO", Id_paciente = 18, Id_dentista = 2},
                new Agendamento{Id_agendamento = 19, Data = Convert.ToDateTime("2022-08-07T14:00:00"), Desc_consulta = "BOTOX", Id_paciente = 19, Id_dentista = 5},
                new Agendamento{Id_agendamento = 20, Data = Convert.ToDateTime("2022-08-07T16:00:00"), Desc_consulta = "CIRURGIA", Id_paciente = 20, Id_dentista = 5},
         };

            private void ImprimirAgendamentos()
            {
                foreach (var item in listaAgendamento)
                {
            
                    Console.WriteLine($"{item.Desc_consulta} {item.Data}");
                }
            }
    }
}
