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
        public void RegistrarNovoPaciente(Paciente paciente);

        public Paciente PegarPaciente(string nomeOuCpf);

        public void ApagarPaciente(Paciente paciente);
    }
}
