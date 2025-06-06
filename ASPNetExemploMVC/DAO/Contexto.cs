using ASPNetExemploMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASPNetExemploMVC.DAO
{
    public class Contexto : DbContext
    {
        //Local que armazena e configura a string de conexão com o banco
        public Contexto(DbContextOptions<Contexto> options) :base(options)
        {

        }
        //Cadastra as classes a serem cadastradas no banco.
        DbSet<Produto> Produtos { get; set; }
    }
}
