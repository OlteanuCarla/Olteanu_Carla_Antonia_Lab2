using Olteanu_Carla_Antonia_Lab2.Models;
namespace Olteanu_Carla_Antonia_Lab2.ViewModels
{
    public class CategoryIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> BookCategories { get; set; }
        
    }
}
