using OdontoCode.Services;

class Program
{
    static void Main()
    {
        PacienteService pacienteService = new PacienteService();
        pacienteService.ImprimirPacientes("024.789.698-28");
    }

}