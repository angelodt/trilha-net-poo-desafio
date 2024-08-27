using System.Numerics;

namespace DesafioPOO.Models
{
    public class Nokia : Smartphone
    {
        protected override string BRANDNAME => "Nokia";

        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }
      
        public override void InstalarAplicativo(string nomeApp)
        {
            try
            {
                nomeApp = nomeApp.ToLower();
                Console.WriteLine($"{BRANDNAME}");
                Console.WriteLine($"Adicionando aplicativo {nomeApp}...");
                base.AdicionarAplicativo(nomeApp);
                Console.WriteLine($"Aplicativo {nomeApp} adicionado.");
            }
            catch (Exception e)
            {                
                Console.WriteLine($"{e.Message}");
            }
        }

        internal new void RemoverAplicativo(string nomeApp)
        {
            try
            {
                nomeApp = nomeApp.ToLower();
                Console.WriteLine($"{BRANDNAME}");
                Console.WriteLine($"Removendo aplicativo {nomeApp}...");
                base.RemoverAplicativo(nomeApp);   
                Console.WriteLine($"Aplicativo {nomeApp} removido.");                             
            }
            catch (Exception e)
            {                
                Console.WriteLine($"{e.Message}");
            }
        }
    }
}