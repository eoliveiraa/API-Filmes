using api_filmes_senai.Context;
using api_filmes_senai.Controllers;
using api_filmes_senai.Domains;
using api_filmes_senai.Interfaces;

namespace api_filmes_senai.Repositories
{

    /// <summary>
    /// Classe que vai implementar a interface IGeneroRepository
    /// ou seja vamos implementar os metodos(Toda a logica)
    /// </summary>
    public class GeneroRepository : IGeneroRepository
    {
        /// <summary>
        /// Variavel privada 
        /// </summary>

        private readonly Filme_Context _context;

        /// <summary>
        /// Construtor do Repositorio
        /// Aqui, toda vez que um costrutor for chamado,
        /// os dados do contexto estarao disponiveis 
        /// </summary>
        /// <param name="contexto"></param>

        public GeneroRepository(Filme_Context contexto)
        { 
           _context = contexto;
        }
        public void Atuaizar(Guid id, Genero genero)
        {
            throw new NotImplementedException();
        }

        public Genero BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }

        public void Cadastrar(Genero novoGenero)
        {
            try
            {
                _context.Genero.Add(novoGenero);

                _context.SaveChanges();
            }
            catch (Exception)
            {
                throw;
            }

        }

        

        public void Deletar(Guid id)
        {
            throw new NotImplementedException();
        }

        public List<Genero> Listar()
        {
            try
            {
                List<Genero> ListaGeneros = _context.Genero.ToList();
                return ListaGeneros;

            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
