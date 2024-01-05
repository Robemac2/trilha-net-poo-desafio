namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        private string Modelo { get; set; }
        private string IMEI { get; set; }
        private int Memoria { get; set; }
        private string Fabricante { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria, string fabricante)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
            Fabricante = fabricante;
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
        public void DetalhesSmartphone()
        {
            Console.WriteLine($"Fabricante: {this.Fabricante}\nNúmero: {this.Numero}\nModelo: {this.Modelo}\nIMEI: {this.IMEI}\nMemória: {this.Memoria} Gb\n");
        }
    }
}