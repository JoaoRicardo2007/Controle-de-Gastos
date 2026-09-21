using ControleDeGastos.Models;

namespace ControleDeGastos.Interfaces
{
    public interface ICarteiraService
    {
        void AdicionarCarteira(Carteira carteira);
        void RemoverCarteira(int id);
        void AtualizarCarteira(int id, Carteira carteiraAtualizada);
        List<Carteira> ListarCarteiras();
    }
}
