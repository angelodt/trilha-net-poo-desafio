
namespace DesafioPOO.Models
{

    public class Iphone : Smartphone
    {
        protected override string BRANDNAME => "Iphone";

        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {            
        }        

        public override void InstalarAplicativo(string nomeApp)
        {
            try
            {
                nomeApp = nomeApp.ToUpper();
                Console.WriteLine($"{BRANDNAME} - Instalando aplicativo {nomeApp}...");
                base.AdicionarAplicativo(nomeApp);
                Console.WriteLine($"{BRANDNAME} - Aplicativo {nomeApp} instalado com sucesso!");
            }
            catch (Exception e)
            {                
                Console.WriteLine($"{BRANDNAME} - {e.Message}");
            }
        }

        internal new void RemoverAplicativo(string nomeApp)
        {
            try
            {
                nomeApp = nomeApp.ToUpper();
                Console.WriteLine($"{BRANDNAME} - Desinstalando aplicativo {nomeApp}...");
                base.RemoverAplicativo(nomeApp);
                Console.WriteLine($"{BRANDNAME} - Aplicativo {nomeApp} desinstalado com sucesso!");
            }
            catch (Exception e)
            {                
                Console.WriteLine($"{BRANDNAME} - {e.Message}");
            }
        }
    }
}