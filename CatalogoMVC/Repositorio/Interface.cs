using CatalogoMVC.Models;

namespace CatalogoMVC.Repositorio
{
    public interface Interface
    {
        
        HomeModel ListarPorId(int id);
        HomeModel Adicionar(HomeModel user);
        bool Deletar(int id);
        HomeModel Atualizar (HomeModel user);
    }
}
