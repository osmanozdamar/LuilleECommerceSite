using LuilleWebAPI.Context;
using LuilleWebAPI.Entities.Concreate;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LuilleWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {

        //Tüm Kategorileri getir.
        [HttpGet]  // http://localhost:5216
        public List<Category> GetCategories() 
        {  
            var ctx = new LuilleContext();
            var categories = ctx.Categories.ToList();

            return categories;
        }

        //Yeni Kategori Ekle.
        [HttpPost("{id}")]
        public string SaveNewProdcy([FromBody]Category category)
        {
            var ctx = new LuilleContext();
            ctx.Categories.Add(category);
            ctx.SaveChanges();
            return "Yeni Kategori Eklendi.";
        }

        [HttpPut("{id:int}")]
        public string UpdateCategory([FromRoute]int id, [FromBody] Category category)
        {
            var ctx = new LuilleContext();

            var categoryEntity=
                ctx.Categories
                   .SingleOrDefault(x=>x.CategoryID == id);
            categoryEntity.CategoryName = category.CategoryName;
            categoryEntity.Description = category.Description;
            categoryEntity.Picture = category.Picture;
            categoryEntity.Products = category.Products;
            ctx.Categories.Update(categoryEntity);
            ctx.SaveChanges();

            return "İşlem Başarılı.";
        }

        //Kategori Sil
        [HttpDelete("{id:int}")]
        public string DeleteCategory([FromRoute] int id)
        {
            var ctx = new LuilleContext();
            var categoryEntity=
                ctx.Categories
                .SingleOrDefault (x=>x.CategoryID == id);
            
            ctx.Categories.Remove(categoryEntity);
            ctx.SaveChanges();


            return "Başarılı şekilde silindi.";

        }

    }
}
