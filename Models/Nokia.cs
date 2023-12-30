namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
            Console.WriteLine($"O numero do seu Nokia é: {numero}, ele é do modelo {modelo}, o seu IMEI é: {imei} e tem uma memoria de {memoria}GB. ");
        }

        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando o aplicativo {nomeApp} no seu Nokia");
        }
    }
}