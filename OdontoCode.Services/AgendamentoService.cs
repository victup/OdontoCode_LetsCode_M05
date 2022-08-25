
using OdontoCode.Domain;
using OdontoCode.Services.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services
{
    public class AgendamentoService : IAgendamentoService
        
    {

            private static List<Agendamento> listaAgendamento = new()
            {
                new Agendamento{Id_agendamento = 1, Data = Convert.ToDateTime("2022-08-05T10:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 1, Id_dentista = 1},
                new Agendamento{Id_agendamento = 2, Data = Convert.ToDateTime("2022-08-06T10:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 2, Id_dentista = 1},
                new Agendamento{Id_agendamento = 3, Data = Convert.ToDateTime("2022-08-05T10:00:00"), Desc_consulta = "EXTRAÇÃO DE SISO", Id_paciente = 3, Id_dentista = 2},
                new Agendamento{Id_agendamento = 4, Data = Convert.ToDateTime("2022-08-05T08:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 4, Id_dentista = 1},
                new Agendamento{Id_agendamento = 5, Data = Convert.ToDateTime("2022-08-06T08:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 5, Id_dentista = 1},
                new Agendamento{Id_agendamento = 6, Data = Convert.ToDateTime("2022-08-06T14:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 6, Id_dentista = 1},
                new Agendamento{Id_agendamento = 7, Data = Convert.ToDateTime("2022-08-06T16:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 7, Id_dentista = 1},
                new Agendamento{Id_agendamento = 8, Data = Convert.ToDateTime("2022-08-06T08:00:00"), Desc_consulta = "CANAL", Id_paciente = 8, Id_dentista = 3},
                new Agendamento{Id_agendamento = 9, Data = Convert.ToDateTime("2022-08-06T10:00:00"), Desc_consulta = "PERIODONTIA", Id_paciente = 9, Id_dentista = 3},
                new Agendamento{Id_agendamento = 10, Data = Convert.ToDateTime("2022-08-07T08:00:00"), Desc_consulta = "CIRURGIA", Id_paciente = 10, Id_dentista = 2},
                new Agendamento{Id_agendamento = 11, Data = Convert.ToDateTime("2022-08-07T10:00:00"), Desc_consulta = "BOTOX", Id_paciente = 11, Id_dentista = 2},
                new Agendamento{Id_agendamento = 12, Data = Convert.ToDateTime("2022-08-05T08:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 12, Id_dentista = 4},
                new Agendamento{Id_agendamento = 13, Data = Convert.ToDateTime("2022-08-06T08:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 13, Id_dentista = 4},
                new Agendamento{Id_agendamento = 14, Data = Convert.ToDateTime("2022-08-06T14:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 14, Id_dentista = 4},
                new Agendamento{Id_agendamento = 15, Data = Convert.ToDateTime("2022-08-07T14:00:00"), Desc_consulta = "LIMPEZA", Id_paciente = 15, Id_dentista = 4},
                new Agendamento{Id_agendamento = 16, Data = Convert.ToDateTime("2022-08-05T08:00:00"), Desc_consulta = "CIRURGIA", Id_paciente = 16, Id_dentista = 5},
                new Agendamento{Id_agendamento = 17, Data = Convert.ToDateTime("2022-08-06T10:00:00"), Desc_consulta = "BOTOX", Id_paciente = 17, Id_dentista = 5},
                new Agendamento{Id_agendamento = 18, Data = Convert.ToDateTime("2022-08-06T10:00:00"), Desc_consulta = "EXTRAÇÃO DE SISO", Id_paciente = 18, Id_dentista = 2},
                new Agendamento{Id_agendamento = 19, Data = Convert.ToDateTime("2022-08-07T14:00:00"), Desc_consulta = "BOTOX", Id_paciente = 19, Id_dentista = 5},
                new Agendamento{Id_agendamento = 20, Data = Convert.ToDateTime("2022-08-07T16:00:00"), Desc_consulta = "CIRURGIA", Id_paciente = 20, Id_dentista = 5},
         };

        private List<Dentista> listDentist = new()
        {
            new Dentista(1, "Aline Adriana Ribeiro Benedita", "046.704.150 - 42", "65412", "(11) 99462 - 8265", true),
            new Dentista(2, "Camila Catarina Rodrigues", "928.726.330 - 22","37626", "(11) 99751 - 4603", true),
            new Dentista(3, "Antônia Natália  Fernandes", "892.073.160 - 80","44156", "(11) 98770 - 2070", true),
            new Dentista(4, "Nina Benedita Duarte", "712.842.250 - 11", "34811", "(11) 98726 - 8615",true),
            new Dentista(5, "Manuela Luiza Lopes", "662.976.630-09", "62791","(11) 99773 - 4685", true),
        };

        private List<Paciente> listPacient = new()
        {
            new Paciente{Id_paciente = 1, Nome = "Benedito Guilherme Oliveira", CPF = "024.789.698-28", Telefone = "(11) 99935-5685", CEP = "08235-720", UF = "SP", Cidade = "São Paulo", Bairro = "Parque Guarani", Rua = "Rua Urari", Numero = 162},
            new Paciente{Id_paciente = 2, Nome = "Mirella Emilly Moreira", CPF = "471.789.853-89", Telefone = "(11) 99985-1695", CEP = "02713-050", UF = "SP", Cidade = "São Paulo", Bairro = "Jardim das Graças", Rua = "Ema Bortolato Bulgari", Numero = 246},
            new Paciente{Id_paciente = 3, Nome = "Diego Caio Gustavo Barros", CPF = "123.789.987-77", Telefone = "(11) 99350-4656", CEP = "02413-000", UF = "SP", Cidade = "São Paulo", Bairro = "Imirim", Rua = "Avenida Engenheiro Caetano Álvares", Numero = 567},
            new Paciente{Id_paciente = 4, Nome = "Sarah Simone Assunção", CPF = "874.789.321-98", Telefone = "(11) 98679-4662", CEP = "05086-900", UF = "SP", Cidade = "São Paulo", Bairro = "Lapa", Rua = "Marquês de Paraná", Numero = 985},
            new Paciente{Id_paciente = 5, Nome = "Caroline Beatriz Gomes", CPF = "147.289.687-25", Telefone = "(11) 99215-8633", CEP = "02755-090", UF = "SP", Cidade = "São Paulo", Bairro = "Jardim Primavera (Zona Norte)", Rua = "Catanduvas do Sul", Numero = 301},
            new Paciente{Id_paciente = 6, Nome = "Jéssica Larissa Clarice Melo", CPF = "753.789.756-72", Telefone = "(11) 99646-8240", CEP = "02188-040", UF = "SP", Cidade = "São Paulo", Bairro = "Parque Novo Mundo", Rua = "Herói da Força Expedicionária Brasileira", Numero = 327},
            new Paciente{Id_paciente = 7, Nome = "Raul Sérgio Araújo", CPF = "321.775.698-88", Telefone = "(11) 98102-3057", CEP = "01049-910", UF = "SP", Cidade = "São Paulo", Bairro = "Centro", Rua = "João Adolfo", Numero = 700},
            new Paciente{Id_paciente = 8, Nome = "Henry Renan Oliver Caldeira", CPF = "429.072.730-19 ", Telefone = "(11) 98401-7700", CEP = "03976-090", UF = "SP", Cidade = "São Paulo", Bairro = "Jardim Sapopemba", Rua = "Nabor Luís da Silva", Numero = 824},
            new Paciente{Id_paciente = 9, Nome = "Caleb Fábio Vinicius Santos", CPF = "916.706.110 - 94", Telefone = "(11) 99175-7486", CEP = "08485-436", UF = "SP", Cidade = "São Paulo", Bairro = "Conjunto Habitacional Santa Etelvina III", Rua = "Universo", Numero = 995},
            new Paciente{Id_paciente = 10, Nome = "Carlos Eduardo Severino Victor Moura", CPF = "728.913.528 - 82", Telefone = "(11) 99693-8412", CEP = "08471-400", UF = "SP", Cidade = "São Paulo", Bairro = "Cidade Tiradentes", Rua = "Antônio Vieira Costa", Numero = 579},
            new Paciente{Id_paciente = 11, Nome = "Matheus Caleb João Gonçalves", CPF = "997.960.578 - 24", Telefone = "(11) 99135-9037", CEP = "08122-480", UF = "SP", Cidade = "São Paulo", Bairro = "Parque Santa Amélia", Rua = "Diogo de Gouveia Osório", Numero = 793},
            new Paciente{Id_paciente = 12, Nome = "Ester Mariane Nascimento", CPF = "416.141.870 - 10", Telefone = "(11) 98425-6381", CEP = "08382-810", UF = "SP", Cidade = "São Paulo", Bairro = "Recanto Verde do Sol", Rua = "Rua do Palanque", Numero = 655},
            new Paciente{Id_paciente = 13, Nome = "Bruna Ester Benedita Dias", CPF = "161.119.078 - 91", Telefone = "(11) 99424-8618", CEP = "02221-170", UF = "SP", Cidade = "São Paulo", Bairro = "Jardim Brasil (Zona Norte)", Rua = "Travessa Vicente Lusitano", Numero = 441},
            new Paciente{Id_paciente = 14, Nome = "Carlos Tomás Gabriel Figueiredo", CPF = "747.231.378 - 58", Telefone = "(11) 98365-7069", CEP = "02224-015", UF = "SP", Cidade = "São Paulo", Bairro = "Jardim Brasil (Zona Norte)", Rua = "Travessa Mariano Latorre", Numero = 546},
            new Paciente{Id_paciente = 15, Nome = "Mariah Renata Giovanna Rocha", CPF = "642.475.480 - 69", Telefone = "(11) 99755-3292", CEP = "02997-275", UF = "SP", Cidade = "São Paulo", Bairro = "Estância Jaraguá", Rua = "Estrada dos Coqueiros", Numero = 408},
            new Paciente{Id_paciente = 16, Nome = "Raquel Eliane Rezende", CPF = "663.851.068 - 10", Telefone = "(11) 98978-5964", CEP = "04472-310", UF = "SP", Cidade = "São Paulo", Bairro = "Jardim Novo Pantanal", Rua = "Estado de Jerusalém", Numero = 804},
            new Paciente{Id_paciente = 17, Nome = "Beatriz Andreia Antônia Porto", CPF = "861.352.318 - 80", Telefone = "(11) 98989-9461", CEP = "03476-020", UF = "SP", Cidade = "São Paulo", Bairro = "Vila Antonieta", Rua = "Minérios Atômicos", Numero = 429},
            new Paciente{Id_paciente = 18, Nome = "Pietro Lucca da Cruz", CPF = "575.313.770 - 98", Telefone = "(11) 99581-9318", CEP = "03570-280", UF = "SP", Cidade = "São Paulo", Bairro = "Parque Savoy City", Rua = "Norma Calegari Galetto", Numero = 127},
            new Paciente{Id_paciente = 19, Nome = "Rita Renata Bernardes", CPF = "969.206.878 - 10", Telefone = "(11) 99932-8350", CEP = "04125-110", UF = "SP", Cidade = "São Paulo", Bairro = "Vila Firmiano Pinto", Rua = "Doutor Francisco Tinoco Cabral", Numero = 714},
            new Paciente{Id_paciente = 20, Nome = "Calebe Mário Martins", CPF = "835.306.478 - 29", Telefone = "(11) 98633-9447", CEP = "08223-010", UF = "SP", Cidade = "São Paulo", Bairro = "Cidade Antônio Estevão de Carvalho", Rua = "Caxinguelé", Numero = 214},
        };


        public AgendamentoService()
        {

        }
        #region Imprimir Agendamentos
        private void ImprimirAgendamentos()
        {
            foreach (var item in listaAgendamento)
            {
            
                Console.WriteLine($"{item.Desc_consulta} {item.Data}");
            }
        }
        #endregion

        #region Buscar por dentista
        public List<int> SearchApointmentForDentistID(List<int> listDentistID)
        {
            var listApointmentID = new List<int>();

            foreach (var item in listaAgendamento)
            {
                foreach (var id in listDentistID)
                {
                    if (item.Id_dentista == id)
                    {
                        listApointmentID.Add(item.Id_agendamento);
                    }
                }
            }
            return listApointmentID;
        }
        public List<int> SearchDentistID(string busca)
        {
            busca = busca.ToLower();
            var listDentistID = new List<int>();

            foreach (var value in listDentist)
            {

                if (value.Nome.ToLower().Contains(busca))
                {
                    listDentistID.Add(value.Id_dentista);
                }
            }
            return listDentistID;
        }
        #endregion

        #region Buscar por Paciente
        public List<int> SearchApointmentForPacientID(List<int> listPacientID)
        {
            var listApointmentID = new List<int>();

            foreach (var item in listaAgendamento)
            {
                foreach (var id in listPacientID)
                {
                    if (item.Id_paciente == id)
                    {
                        listApointmentID.Add(item.Id_agendamento);
                    }
                }
            }
            return listApointmentID;
        }
        public List<int> SearchPacientIDForCPF(string busca)
        {
            busca = busca.ToLower();
            var listPacientID = new List<int>();

            foreach (var value in listPacient)
            {

                if (value.CPF.ToLower().Contains(busca))
                {
                    listPacientID.Add(value.Id_paciente);
                }
            }
            return listPacientID;
        }

        public List<int> SearchPacientIDForName(string busca)
        {
            busca = busca.ToLower();
            var listPacientID = new List<int>();

            foreach (var value in listPacient)
            {

                if (value.Nome.ToLower().Contains(busca))
                {
                    listPacientID.Add(value.Id_paciente);
                }
            }
            return listPacientID;
        }

        #endregion

        #region Buscar por descrição da consulta
        public List<int> SearchApointmentID(string busca)
        {
            busca = busca.ToLower();
            var listApointmentID = new List<int>();

            foreach (var item in listaAgendamento)
            {

                if (item.Desc_consulta.ToLower().Contains(busca))
                {
                    listApointmentID.Add(item.Id_agendamento);
                }
            }
            return listApointmentID;
        }
        #endregion

        #region Buscar por data
        public List<int> SearchApointmentID(DateTime busca)
        {
            var listApointmentID = new List<int>();

            foreach (var item in listaAgendamento)
            {

                if (item.Data.Equals(busca))
                {
                    listApointmentID.Add(item.Id_agendamento);
                }
            }
            return listApointmentID;
        }
        #endregion

        #region Novo agendamento
        public void NewAppointment(Agendamento agendamento)
        {
            
       
            listaAgendamento.Add(agendamento);
            
        }
        #endregion

        #region Cancelar agendamento
        public void CancelAppointment(Agendamento agendamento)
        {
            listaAgendamento.Remove(agendamento);
        }
        #endregion

        #region Alterar agendamento
        public void ChangeAppointment(string info, DateTime data)
        {
            var lista = listaAgendamento.Where(agnd => agnd.Desc_consulta == info || agnd.Data == data).ToList();
            if (lista.Exists (agnd => agnd.Desc_consulta == info || agnd.Data == data))
            {
                foreach (var agendamento in listaAgendamento)
                {
                    agendamento.Desc_consulta = info;
                    agendamento.Data = data;
                }
            }
        }
        #endregion

        #region Gerar id
        public int GerarNovoId()
        {
            int novoID = 0;
            foreach (var item in listaAgendamento)
            {
                novoID = Math.Max(novoID, item.Id_agendamento);
            }

            return novoID + 1;
        }
        #endregion

        public string GetPacientName(int id)
        {
            string name = "";
            var paciente = new Paciente();
            foreach (var item in listPacient)
            {
                if (item.Id_paciente == id)
                {
                    name = item.Nome;
                }
            }
            return name;
        }

        public string GetDentistName(int id)
        {
            string name = "";
            var dentista = new Dentista();
            foreach (var item in listDentist)
            {
                if (item.Id_dentista == id)
                {
                    name = item.Nome;
                }
            }
            return name;
        }

        public List<Agendamento> SearchForApointment(string cpfPaciente, string nomePaciente, string nomeDentista, string ds_consulta, DateTime data_ag)
        {
            var busca = new AgendamentoService();
            var listaImp = new List<int>();
            var listForDentistName = busca.SearchApointmentForDentistID(busca.SearchDentistID(nomeDentista));
            var listForPacientCPF = busca.SearchApointmentForPacientID(busca.SearchPacientIDForCPF(cpfPaciente));
            var listForPacientName = busca.SearchApointmentForPacientID(busca.SearchPacientIDForName(nomePaciente));
            var listForConsultDS = busca.SearchApointmentID(ds_consulta);
            var listForConsultData = busca.SearchApointmentID(data_ag);

            var list = new List<Agendamento>();
            foreach (var item in listaAgendamento)
            {
                if ((listForDentistName.Contains(item.Id_agendamento) || nomeDentista == "") &&
                    (listForPacientCPF.Contains(item.Id_agendamento) || cpfPaciente == "") &&
                    (listForDentistName.Contains(item.Id_agendamento) || nomePaciente == "") &&
                    (listForConsultDS.Contains(item.Id_agendamento) || ds_consulta == "") &&
                    (listForConsultData.Equals(item.Id_agendamento) || data_ag == DateTime.MinValue))
                {
                    list.Add(item);
                }
            }
            return list;    
        }
    }
}
