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

        public List<int> SearchDentistID(string busca);

        public List<int> SearchApointmentForPacientID(List<int> listPacientID);

        public string SearchPacintCPFForID(int id);

        public List<int> SearchApointmentID(string busca);

        public List<int> SearchPacientIDForName(string busca);

        public List<int> SearchPacientIDForCPF(string busca);

        public List<int> SearchApointmentID(DateTime busca);

        public void NewAppointment(Agendamento agendamento);

        public bool CancelAppointment(int id_agendamento);

        public bool ChangeAppointment(int id_agendamento, DateTime data, string desc_consulta);

        public string GetPacientName(int id);

        public string GetDentistName(int id);

        public int GerarNovoId();

        public List<Agendamento> SearchForApointment(string cpfPaciente, string nomePaciente, string nomeDentista, string ds_consulta);

        public string AgendamentoCount();

        public Agendamento BuscarAgendamentoPorID(int id);

        
    }
}
