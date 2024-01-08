namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Você instalou no seu Nokia o aplicativo {nomeApp}!");
        }

        public override string ToString()
        {
            return $"\nInformações do Nokia:\n\nNúmero - {Numero}\nModelo - {Modelo}\nIMEI - {IMEI}\nMemória - {Memoria}";
        }
    }
}