
using System.Collections.Generic;

namespace dominio
{   
    public class Carro
    {
        public int IdCarro { get; set; }
        public int IdMarca { get; set; }
        public string Modelo { get; set; }
        public int Ano { get; set; }
        public double precoBasico { get; set; }

        public Marca Marc { get; set; } //isso se chama AGREGAÇÃO
        //public Acessorio Acess { get; set; } //isso se chama AGREGAÇÃO
        public List<Acessorio> Acess { get; set; }
        
        //Obs 1: ver onde é maiúscula e onde é minúscula
        //Obs 3: criar o método precoTotal().

        /// <summary>
        /// Sobrecarga do método 
        /// </summary>
        public Carro(){}
        
        /// <summary>
        /// Método que declara as variáveis que definem o CARRO
        /// </summary>
        /// <param name="IdCarro">id do carro</param>
        /// <param name="Modelo">modelo do carro</param>
        /// <param name="Ano">Ano do carro</param>
        /// <param name="precoBasico">preço básico do carro, sem acessórios</param>
        public Carro(int idcarro,int idmarca, string modelo, int ano, double precobasico){
            this.IdCarro = idcarro;
            this.IdMarca = idmarca;
            this.Modelo = modelo;
            this.Ano = ano;
            this.precoBasico = precobasico;

            //this.Marc = marca;
            //this.Acess = acessorio;
            Acess = new List<Acessorio>();
        }

        public double precoTotal()
        {
            double soma = 0;
            for (int i = 0; i < Acess.Count; i++)
            {
                soma = soma + Acess[i].PrecoAcessorio;
            }
            soma = soma + precoBasico;

            return soma;
        }

        public override string ToString()
        {
            string s = IdCarro.ToString() 
            + ", " 
            + Modelo 
            + ", ano " 
            + Ano.ToString() 
            + ", preço básico R$ " 
            + precoBasico.ToString("F2")
            + "; preço total: R$: " 
            + precoTotal().ToString("F2") 
            + "\n";
            
            for (int i = 0; i < Acess.Count; i++)
            {
                s = s + Acess[i] + "\n";
            }
            s = s + "preço total: R$" + precoTotal() + "\n";
            return s;
        }
    }
}
