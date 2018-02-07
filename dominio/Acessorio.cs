
namespace dominio
{   
    public class Acessorio
    {
        public string NomeAcessorio { get; set; } 
        public double PrecoAcessorio { get; set; } 
        
        public Acessorio(string nomeacessorio, double precoacessorio) {
            this.NomeAcessorio = nomeacessorio;
            this.PrecoAcessorio = precoacessorio;
        }

        public override string ToString()
        {
            return NomeAcessorio
                + "; Preço: R$: "
                + PrecoAcessorio.ToString("F2");
        }
    }
}
