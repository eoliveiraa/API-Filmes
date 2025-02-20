using api_filmes_senai.Domains;

namespace api_filmes_senai.Interfaces
{
    public interface IFilmeRepository
    {

        void Cadastrar(Filme novoFilme);

        List<Filme> Listar();

        void Atualizar (Guid id);

        void deletar (Guid id);

        Filme BuscarPorId (Guid id);


    }
}
