//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using APIPractice2.Models;

//namespace APIPractice2.Data
//{
//    public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
//    {
//        public DataContext CreateDbContext(string[] args)
//        {
//            var optionsBuilder = new DbContextOptionsBuilder<DataContext>();

//            optionsBuilder.UseSqlServer(
//                "Server=(localdb)\\mssqllocaldb;Database=PokemonDB;Trusted_Connection=True;TrustServerCertificate=True;");

//            return new DataContext(optionsBuilder.Options);
//        }
//    }
//}
