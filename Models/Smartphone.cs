namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        // TODO: Implementar as propriedades faltantes de acordo com o diagrama -- DONE!
        private string Modelo { get; set; }
        private string Serie { get; set; }
        private int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string serie, int memoria)
        {
            Numero = numero;
            // TODO: Passar os parâmetros do construtor para as propriedades -- DONE!
            Modelo = modelo;
            Serie = serie;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine("Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine("Recebendo ligação...");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}