namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone" -- DONE!
    public class Nokia : Smartphone
    {
        public Nokia(string numero, string modelo, string serie, int memoria) : base(numero, modelo, serie, memoria)
        {
        }
        // TODO: Sobrescrever o método "InstalarAplicativo" -- DONE!
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalando {nomeApp} em celular Nokia");
        }
    }
}