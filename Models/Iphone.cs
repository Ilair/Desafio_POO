namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public override void InstalarAplicativo(string nomeApp)
        { 
            Console.WriteLine("Instalando Aplicativo Iphone " + nomeApp);
        }

        public Iphone(string numero, string modelo, string imei, int memoria)
        : base(numero, modelo, imei, memoria){}
    }
}