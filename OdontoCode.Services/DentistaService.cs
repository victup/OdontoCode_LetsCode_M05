using OdontoCode.Domain;
using OdontoCode.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services
{
    public class DentistaService : IDentistaService
    {

        private static List<Dentista> dentistTable = new()
        {
            new Dentista(1, "Aline Adriana Ribeiro", "046.704.150 - 42", "65412", "(11) 99462 - 8265", true),
            new Dentista(2, "Camila Catarina Rodrigues", "928.726.330 - 22","37626", "(11) 99751 - 4603", true),
            new Dentista(3, "Antônia Natália  Fernandes", "892.073.160 - 80","44156", "(11) 98770 - 2070", true),
            new Dentista(4, "Nina Benedita Duarte", "712.842.250 - 11", "34811", "(11) 98726 - 8615",true),
            new Dentista(5, "Manuela Luiza Lopes", "662.976.630-09", "62791","(11) 99773 - 4685", true),
        };

        public DentistaService()
        {

        }

        public void RegisterNewDentist(Dentista dentista)
        {
            dentistTable.Add(dentista);
        }

        public Dentista GetDentist(string nameOrCro)
        {
                Dentista dentist = new Dentista();

            foreach (var value in dentistTable)
                {
           
                    if ((value.Nome == nameOrCro || value.CRO == nameOrCro) && value.Ativo)
                        dentist = new Dentista(value.Id_dentista, value.Nome, value.CPF, value.CRO,value.Telefone, value.Ativo);         
                }

                return dentist;

        }

        public void DeleteDentist(Dentista dentist)
        {
            dentistTable
                .Where(x => x.Nome == dentist.Nome || x.CRO == dentist.CRO)
                .Select(x => x.Ativo = false);
        }

    }
    
}