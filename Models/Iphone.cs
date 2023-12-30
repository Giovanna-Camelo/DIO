namespace DesafioPOO.Models
{
    
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
             Console.WriteLine($"O numero do seu Iphone é: {numero}, seu modelo é {modelo}, o seu IMEI é: {imei} e tem uma memoria de {memoria}GB. ");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"O aplicativo {nomeApp} está sendo instalado no seu Iphone");
        }

    }
}