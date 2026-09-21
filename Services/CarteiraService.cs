using ControleDeGastos.Models;

namespace ControleDeGastos.Services
{
    public class CarteiraService : Interfaces.ICarteiraService
    {
        private readonly List<Carteira> _carteiras = new List<Carteira>();

        public List<Carteira> ListarCarteiras()
        {
            return _carteiras;
        }
        public void AdicionarCarteira(Carteira carteira)
        {
            _carteiras.Add(carteira);
        }

        public void RemoverCarteira(int id)
        {
            var carteira = _carteiras.FirstOrDefault(c => c.Id == id);
            if (carteira != null)
            {
                _carteiras.Remove(carteira);
            }
        }

        public void AtualizarCarteira(int id, Carteira carteiraAtualizada)
        {
            var carteira = _carteiras.FirstOrDefault(c => c.Id == id);
            if (carteira != null)
            {
                carteira.Descricao = carteiraAtualizada.Descricao;
                carteira.Valor = carteiraAtualizada.Valor;
                carteira.Data = carteiraAtualizada.Data;
                carteira.Tipo = carteiraAtualizada.Tipo;
            }
        }
    }
}
