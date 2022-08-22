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
            new Dentista{Id_dentista = 1, Nome = "Aline Adriana Ribeiro", CPF = "046.704.150 - 42", CRO = "65412", Telefone = "(11) 99462 - 8265"},
            new Dentista{Id_dentista = 2, Nome = "Camila Catarina Rodrigues", CPF = "928.726.330 - 22", CRO = "37626", Telefone = "(11) 99751 - 4603"},
            new Dentista{Id_dentista = 3, Nome = "Antônia Natália  Fernandes", CPF = "892.073.160 - 80", CRO = "44156", Telefone = "(11) 98770 - 2070"},
            new Dentista{Id_dentista = 4, Nome = "Nina Benedita Duarte", CPF = "712.842.250 - 11", CRO = "34811", Telefone = "(11) 98726 - 8615"},
            new Dentista{Id_dentista = 5, Nome = "Manuela Luiza Lopes", CPF = "662.976.630-09", CRO = "62791", Telefone = "(11) 99773 - 4685"},
        };
    }
}