namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        protected abstract string BRANDNAME { get; }

        public List<string> Aplicativos { get; set; } = new List<string>();

        public Smartphone(string numero, string modelo, string imei, int memoria)
        {
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar()
        {
            Console.WriteLine($"{BRANDNAME} - Ligando...");
        }

        public void ReceberLigacao()
        {
            Console.WriteLine($"{BRANDNAME} - Recebendo ligação...");
        }

        public void InfoSmartphone() {
            Console.WriteLine($"Informações:");
            Console.WriteLine($"{BRANDNAME} - Modelo: {Modelo} - IMEI: {IMEI} - Memoria: {Memoria} - Numero: {Numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);

        protected void AdicionarAplicativo(string nomeApp) {

            if (nomeApp.Trim().Length > 0) {
                Aplicativos.Add(nomeApp);
            }
            else throw new Exception($"Nome do aplicativo não encontrado!");            
        }

        private bool LocalizarAplicativo(String nomeApp) {
            if (nomeApp.Trim().Length > 0 &&
                Aplicativos.Any(x => x.Trim().ToUpper() == nomeApp.Trim().ToUpper()))
            {
                return true;
            }
            return false;
        }

        public void RemoverAplicativo(string nomeApp)
        {
            if(LocalizarAplicativo(nomeApp)) {
                Aplicativos.Remove(nomeApp);
            }else {
                throw new Exception($"Aplicativo {nomeApp} não encontrado!");
            }
        }

        public void ListarAplicativosInstalados()
        {
            if(Aplicativos.Count > 0) {
                Console.WriteLine($"{BRANDNAME} - Lista de aplicativos:");
                foreach (string app in Aplicativos)
                {
                    Console.WriteLine(app);
                }
            } else {
                Console.WriteLine($"{BRANDNAME} - Lista de Aplicativos Vazia.");
            }
        }        
    }
}