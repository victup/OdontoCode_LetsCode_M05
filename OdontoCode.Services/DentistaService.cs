using OdontoCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services
{
    public class DentistaService
    {

        private static List<Dentista> listaDentista = new()
        {
            new Dentista{Id_dentista = 1, Nome = "Aline Adriana Ribeiro", CRO = "65412", Telefone = "(11) 99462 - 8265"},
            new Dentista{Id_dentista = 2, Nome = "Camila Catarina Rodrigues", CRO = "37626", Telefone = "(11) 99751 - 4603"},
            new Dentista{Id_dentista = 3, Nome = "Antônia Natália  Fernandes", CRO = "44156", Telefone = "(11) 98770 - 2070"},
            new Dentista{Id_dentista = 4, Nome = "Nina Benedita Duarte", CRO = "34811", Telefone = "(11) 98726 - 8615"},
            new Dentista{Id_dentista = 5, Nome = "Manuela Luiza Lopes", CRO = "62791", Telefone = "(11) 99773 - 4685"},
        };
    }
}
