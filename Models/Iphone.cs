namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){}

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Agora você poderá desfrutar do aplicativo {nomeApp}, no seu Iphone!");
        }

        public override string ToString()
        {
            return $"\nInformações do Iphone:\n\nNúmero - {Numero}\nModelo - {Modelo}\nIMEI - {IMEI}\nMemória - {Memoria}";
        }
    }
}