using CatalogoMVC.Models;

namespace CatalogoMVC.Helper
{
    public interface ISessao
    {
        void RemoverSessaoUsuario();
        void CriarSessaoDoUsuario(HomeModel usuario);
        
        HomeModel BuscarSessaoDoUsuario();
    }
}
