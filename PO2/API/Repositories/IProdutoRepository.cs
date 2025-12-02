using Models;

//Desenvolvido por Laysa Bernardes e Lucas Lopes

namespace API.Repositories
{
    public interface IProdutoRepository
    {
        Task<Produto> AddAsync(Produto produto);
        Task<Produto?> GetByIdAsync(int id);
        Task<IEnumerable<Produto>> GetAllAsync();  
        Task UpdateAsync(Produto produto, int usuarioId);
        Task<bool> DeleteAsync(int id);
    }
}
