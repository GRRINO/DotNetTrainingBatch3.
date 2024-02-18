using DotNetTrainingBatch3.WebApi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DotNetTrainingBatch3.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly AppDbContext _db;
        public BlogController()
        {
            _db = new AppDbContext();
        }
        [HttpGet]
        public IActionResult GEtBlog()
        {
            List<BlogModel> lst = _db.blogs.OrderByDescending(x => x.BlogId).ToList();
            return Ok(lst);
        }

        [HttpGet("{id}")]
        public IActionResult GEtBlog(int id)
        {
            BlogModel? item = _db.blogs.FirstOrDefault(item => item.BlogId == id);
            if (item is null)
            {

                return NotFound("No Data Found");
            }

            return Ok(item);
        }

        [HttpPost]
        public IActionResult CreatBlog(BlogModel blog)
        {
            _db.blogs.Add(blog);
            int result = _db.SaveChanges();
            string message = result > 0 ? "Creat successful" : "Creat Failed";
            return Ok(result);
        }

        [HttpPut ("{id}")]
        public IActionResult UpdateBlog(int id , BlogModel blog)
        {
            BlogModel? item = _db.blogs.FirstOrDefault(item => item.BlogId == id);
            if (item is null)
            {
               
                return NotFound("No Data Found");
            }

            item.BlogTitle = blog.BlogTitle;
            item.BlogAuthor = blog.BlogAuthor;
            item.BlogContent = blog.BlogContent;

            int result = _db.SaveChanges();
            string message = result > 0 ? "Updating Successful. " : "Updating Failed.";
            return Ok(message);
        }

        [HttpDelete ("{id}")]
        public IActionResult DeleteBlog(int id)
        {
            BlogModel? item = _db.blogs.FirstOrDefault(item => item.BlogId == id);
            if (item is null)
            {

                return NotFound("No Data Found");
            }
            _db.blogs.Remove(item);

            int result = _db.SaveChanges();
            string message = result > 0 ? "Deleting Successful. " : "Deleting Failed.";
            return Ok(message);
        }

    }
}
