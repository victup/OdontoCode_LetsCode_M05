using OdontoCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services.Interfaces
{
    public interface IDentistaService
    {
        public void RegistrarDentista(Dentista dentista);

        public Dentista BuscarDentista(string busca);

        public void DesligarDentista(Dentista dentista);

        public void AlterarDentista(string cpfAntigo, Dentista dentista);

        public int GerarId();
    }
}
