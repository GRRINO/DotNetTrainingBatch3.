using DotNetTrainingBatch3.ConsoleApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNetTrainingBatch3.ConsoleApp.EFCoreExamples
{
    public class EFCoreExample
    {
        public void read()
        {
            AppDbContext db = new AppDbContext();
            List<BlogModel> lst = db.blogs.ToList();

            foreach(BlogModel item in lst)
            {
                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogContent); 
            }
        }

        public void edit(int id)
        {
            AppDbContext db = new AppDbContext();
            BlogModel item = db.blogs.FirstOrDefault(item => item.BlogId == id);
            if(item is null)
            {
                Console.WriteLine("No Data Found");
                return;
            }
            Console.WriteLine(item.BlogId);
            Console.WriteLine(item.BlogTitle);
            Console.WriteLine(item.BlogAuthor);
            Console.WriteLine(item.BlogContent);

        }

        public void creat(string title,string author,string content)
        {
            BlogModel blog = new BlogModel()
            {
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };
            AppDbContext db = new AppDbContext();
            db.Add(blog);
            int result = db.SaveChanges();
            Console.Write(result > 0 ? "Saving Successful. " : "Saving Failed.");

        }

        public void update(int id,string title, string author, string content)
        {
            AppDbContext db = new AppDbContext();
            BlogModel item = db.blogs.FirstOrDefault(item => item.BlogId == id);
            if (item is null)
            {
                Console.WriteLine("No Data Found");
                return;
            }

            item.BlogTitle = title;
            item.BlogAuthor = author;
            item.BlogContent = content;

            int result = db.SaveChanges();
            Console.Write(result > 0 ? "Updating Successful. " : "Updating Failed.");

        }
        public void delete(int id)
        {
            AppDbContext db = new AppDbContext();
            BlogModel item = db.blogs.FirstOrDefault(item => item.BlogId == id);
            if (item is null)
            {
                Console.WriteLine("No Data Found");
                return;
            }

            db.blogs.Remove(item);

            int result = db.SaveChanges();
            Console.Write(result > 0 ? "deleting Successful. " : "deleting Failed.");

        }

    }
}
