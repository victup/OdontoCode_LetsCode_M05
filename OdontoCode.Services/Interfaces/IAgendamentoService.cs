using OdontoCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services.Interfaces
{
    public interface IAgendamentoService
    {
        public List<int> SearchApointmentForDentistID(List<int> listDentistID);

        public List<int> SearchApointmentForPacientID(List<int> listPacientID);

        public List<int> SearchApointmentID(string busca);

        public List<int> SearchApointmentID(DateTime busca);

        public void NewAppointment(Agendamento agendamento);

        public void CancelAppointment(Agendamento agendamento);

        public void ChangeAppointment(string info, DateTime data);

        public string GetPacientName(int id);

        public string GetDentistName(int id);

        public int GerarNovoId();

        public List<Agendamento> SearchForApointment(string cpfPaciente, string nomePaciente, string nomeDentista, string ds_consulta, DateTime data_ag);

    }
}
