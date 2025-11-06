namespace _S__Single_Responsibility_Principle.INCORRECTO
{
    public class ReportService
    {
        public void GenerateReport() { Console.WriteLine("Reporte generado"); }
        public void SaveToDatabase() { Console.WriteLine("Guardado en la DDBB"); }
        public void SendEmail() { Console.WriteLine("Email enviado"); }
    }
}
