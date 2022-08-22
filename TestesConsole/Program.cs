using OdontoCode.Services;

class Program
{
    static void Main()
    {
        PacienteService pacienteService = new PacienteService();
        pacienteService.ImprimirPacientes();
    }

}