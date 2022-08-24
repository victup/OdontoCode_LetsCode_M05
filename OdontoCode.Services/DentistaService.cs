using OdontoCode.Domain;
using OdontoCode.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services
{
    public class DentistaService : IDentistaService
    {

        private static List<Dentista> listaDentista = new()
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

        public bool RegistrarDentista(Dentista dentista)
        {
            var possuiDentista = listaDentista.Where(x => x.CPF.Equals(dentista.CPF) || x.CRO.Equals(dentista.CRO));
           
            if(possuiDentista.Any())
                return false;
           
            else
            {
                listaDentista.Add(dentista);
                return true;
            }

           
        }

        public Dentista BuscarDentista(string busca)
        {
                Dentista dentist = new Dentista();

            foreach (var value in listaDentista)
                {
           
                    if ((value.Nome == busca || value.CRO == busca || value.CPF == busca) && value.Ativo)
                        dentist = new Dentista(value.Id_dentista, value.Nome, value.CPF, value.CRO,value.Telefone, value.Ativo);         
                }

                return dentist;

        }

        public void DesligarDentista(Dentista dentista)
        {
            listaDentista
                .Where(x => x.CPF.Equals(dentista.CPF) && x.Ativo.Equals(true))
                .Select(x => x.Ativo = false).ToList();
            
        }

        public void AlterarDentista(string cpfAntigo, Dentista dentista)
        {
            listaDentista
              .Where(x => x.CPF.Equals(cpfAntigo))
              .Select(x =>  
              {
                  x.Nome = dentista.Nome;
                  x.CRO = dentista.CRO;
                  x.CPF = dentista.CPF;
                  x.Telefone = dentista.Telefone;
                  return x;
              }).ToList();


            //foreach (var value in listaDentista)
            //{
            //    if ((value.CPF == cpfAntigo))
            //    {
            //        value.Nome = dentista.Nome;
            //        value.CRO = dentista.CRO;
            //        value.CPF = dentista.CPF;
            //        value.Telefone = dentista.Telefone;
            //    }
            //}
        }


        public int GerarId()
        {
            int idDisponivel = 0;

            foreach (var item in listaDentista)
            {
                if (item.Id_dentista > idDisponivel)
                    idDisponivel = item.Id_dentista+1;
            }
             
           return idDisponivel;
       }

    }
    
}