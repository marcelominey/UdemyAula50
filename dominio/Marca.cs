
namespace dominio
{   
    public class Marca
    {
        public int IdMarca { get; set; }
        public string Nome { get; set; } 
        public string Pais { get; set; } 
        
        public Marca(int idmarca, string nome, string pais) {
            this.IdMarca = idmarca;
            this.Nome = nome;
            this.Pais = pais;
        }

        public override string ToString()
        {
            return IdMarca.ToString()
                + "; "
                + Nome
                + "; " 
                + Pais;
        }
    }
}
