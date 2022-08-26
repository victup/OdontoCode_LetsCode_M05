using OdontoCode.Domain;
using OdontoCode.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services
{
    public class PacienteService : IPacienteService
    {
        private static List<Paciente> listaPaciente = new()
        {
            new Paciente(1, "Benedito Guilherme Oliveira", "024.789.698-28", "(11) 99935-5685", "08235-720", "SP", "São Paulo", "Parque Guarani", "Rua Urari", 162, true),
            new Paciente(2, "Mirella Emilly Moreira", "471.789.853-89", "(11) 99985-1695", "02713-050", "SP", "São Paulo", "Jardim das Graças", "Ema Bortolato Bulgari", 246, true),
            new Paciente(3, "Diego Caio Gustavo Barros", "123.789.987-77", "(11) 99350-4656", "02413-000", "SP", "São Paulo", "Imirim", "Avenida Engenheiro Caetano Álvares", 567, true),
            new Paciente(4, "Sarah Simone Assunção", "874.789.321-98", "(11) 98679-4662", "05086-900", "SP", "São Paulo", "Lapa", "Marquês de Paraná", 985, true),
            new Paciente(5, "Caroline Beatriz Gomes", "147.289.687-25", "(11) 99215-8633", "02755-090", "SP", "São Paulo", "Jardim Primavera (Zona Norte)", "Catanduvas do Sul", 301, true),
            new Paciente(6, "Jéssica Larissa Clarice Melo", "753.789.756-72", "(11) 99646-8240", "02188-040", "SP", "São Paulo", "Parque Novo Mundo", "Herói da Força Expedicionária Brasileira", 327, true),
            new Paciente(7, "Raul Sérgio Araújo", "321.775.698-88", "(11) 98102-3057", "01049-910", "SP", "São Paulo", "Centro", "João Adolfo", 700, true),
            new Paciente(8, "Henry Renan Oliver Caldeira", "429.072.730-19 ", "(11) 98401-7700", "03976-090", "SP", "São Paulo", "Jardim Sapopemba", "Nabor Luís da Silva", 824, true),
            new Paciente(9, "Caleb Fábio Vinicius Santos", "916.706.110 - 94", "(11) 99175-7486", "08485-436", "SP", "São Paulo", "Conjunto Habitacional Santa Etelvina III", "Universo", 995, true),
            new Paciente(10, "Carlos Eduardo Severino Victor Moura", "728.913.528 - 82", "(11) 99693-8412", "08471-400", "SP", "São Paulo", "Cidade Tiradentes", "Antônio Vieira Costa", 579, true),
            new Paciente(11, "Matheus Caleb João Gonçalves", "997.960.578 - 24", "(11) 99135-9037", "08122-480", "SP", "São Paulo", "Parque Santa Amélia", "Diogo de Gouveia Osório", 793, true),
            new Paciente(12, "Ester Mariane Nascimento", "416.141.870 - 10", "(11) 98425-6381", "08382-810", "SP", "São Paulo", "Recanto Verde do Sol", "Rua do Palanque", 655, true),
            new Paciente(13, "Bruna Ester Benedita Dias", "161.119.078 - 91", "(11) 99424-8618", "02221-170", "SP", "São Paulo", "Jardim Brasil (Zona Norte)", "Travessa Vicente Lusitano", 441, true),
            new Paciente(14, "Carlos Tomás Gabriel Figueiredo", "747.231.378 - 58", "(11) 98365-7069", "02224-015", "SP", "São Paulo", "Jardim Brasil (Zona Norte)", "Travessa Mariano Latorre", 546, true),
            new Paciente(15, "Mariah Renata Giovanna Rocha", "642.475.480 - 69", "(11) 99755-3292", "02997-275", "SP", "São Paulo", "Estância Jaraguá", "Estrada dos Coqueiros", 408, true),
            new Paciente(16, "Raquel Eliane Rezende", "663.851.068 - 10", "(11) 98978-5964", "04472-310", "SP", "São Paulo", "Jardim Novo Pantanal", "Estado de Jerusalém", 804, true),
            new Paciente(17, "Beatriz Andreia Antônia Porto", "861.352.318 - 80", "(11) 98989-9461", "03476-020", "SP", "São Paulo", "Vila Antonieta", "Minérios Atômicos", 429, true),
            new Paciente(18, "Pietro Lucca da Cruz", "575.313.770 - 98", "(11) 99581-9318", "03570-280", "SP", "São Paulo", "Parque Savoy City", "Norma Calegari Galetto", 127, true),
            new Paciente(19, "Rita Renata Bernardes", "969.206.878 - 10", "(11) 99932-8350", "04125-110", "SP", "São Paulo", "Vila Firmiano Pinto", "Doutor Francisco Tinoco Cabral", 714, true),
            new Paciente(20, "Calebe Mário Martins", "835.306.478 - 29", "(11) 98633-9447", "08223-010", "SP", "São Paulo", "Cidade Antônio Estevão de Carvalho", "Caxinguelé", 214, true),
        };

        public PacienteService()
        {

        }
        public bool RegistrarNovoPaciente(Paciente paciente)
        {
            var possuiPaciente = listaPaciente.Where(x => x.CPF == paciente.CPF);

            if (possuiPaciente.Any())
                return false;

            else
            {
                listaPaciente.Add(paciente);
                return true;
            }
        }

        public Paciente ObterPaciente(string resultado)
        {
            Paciente paciente = new Paciente();
            foreach (var valor in listaPaciente)
            {
                if ((valor.Nome == resultado || valor.CPF == resultado || valor.Telefone == resultado) && valor.Ativo)
                    paciente = new Paciente(valor.Id_paciente, valor.Nome, valor.CPF, valor.Telefone, valor.CEP, valor.UF, valor.Cidade, valor.Bairro, valor.Rua, valor.Numero, valor.Ativo);
            }
            return paciente;
        }

        public void ApagarPaciente(Paciente paciente)
        {
            listaPaciente
                .Where(x => x.CPF.Equals(paciente.CPF) && x.Ativo.Equals(true))
                .Select(x => x.Ativo = false).ToList();
        }

        public void AlterarPaciente(string cpfAntigo, Paciente paciente)
        {
            listaPaciente
              .Where(x => x.CPF.Equals(cpfAntigo))
              .Select(x =>
              {
                  x.Nome = paciente.Nome;
                  x.CPF = paciente.CPF;
                  x.Telefone = paciente.Telefone;
                  x.CEP = paciente.CEP;
                  x.UF = paciente.UF;
                  x.Cidade = paciente.Cidade;
                  x.Bairro = paciente.Bairro;
                  x.Rua = paciente.Rua;
                  x.Numero = paciente.Numero;
                  return x;
              }).ToList();
        }


        public int GerarId()
        {
            int idDisponivel = 0;

            foreach (var item in listaPaciente)
            {
                if (item.Id_paciente > idDisponivel)
                    idDisponivel = item.Id_paciente + 1;
            }

            return idDisponivel;
        }
    }
}
