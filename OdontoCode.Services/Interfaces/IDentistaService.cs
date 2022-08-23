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
        public void RegisterNewDentist(Dentista dentista);


        public Dentista GetDentist(string nameOrCro);

        public void DeleteDentist(Dentista dentist);
    }
}
