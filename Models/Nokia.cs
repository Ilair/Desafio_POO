namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        {
             Console.WriteLine("Instalando Aplicativo Nokia " + nomeApp);
        }

        public Nokia(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria)
        { }
    }
}