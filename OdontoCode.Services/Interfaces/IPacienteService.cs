using OdontoCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services.Interfaces
{
    public interface IPacienteService
    {
        public bool RegistrarNovoPaciente(Paciente paciente);

        public Paciente ObterPaciente(string nomeOuCpf);

        public void ApagarPaciente(Paciente paciente);

        public void AlterarPaciente(string cpfAntigo, Paciente paciente);

        public int GerarId();
    }
}
