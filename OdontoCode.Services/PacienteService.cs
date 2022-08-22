using OdontoCode.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OdontoCode.Services
{
    public class PacienteService
    {
        private static List<Paciente> listaPaciente = new()
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

        public void ImprimirPacientes()
        {
            foreach (var item in listaPaciente)
            {

                Console.WriteLine($"{item.Nome} {item.CPF} {item.Ativo}");
            }
        }
    }


}
