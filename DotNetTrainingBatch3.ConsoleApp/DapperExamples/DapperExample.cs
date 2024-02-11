using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using DotNetTrainingBatch3.ConsoleApp.Models;
using System.Reflection.Metadata;

namespace DotNetTrainingBatch3.ConsoleApp.DapperExamples
{
    public class DapperExample
    {
        private readonly SqlConnectionStringBuilder _sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
        {
            DataSource = "DESKTOP-G92HAN0\\SQLEXPRESS01",
            InitialCatalog = "TestDb",
            UserID = "sa",
            Password = "yy@79250"
        };
        //read
        public void read()
        {
           
            
            string query = "select * from tbl_blog";
            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            List<BlogModel> lst = db.Query<BlogModel>(query).ToList();


            foreach(BlogModel item in lst)
            {
                Console.WriteLine(item.BlogId);
                Console.WriteLine(item.BlogTitle);
                Console.WriteLine(item.BlogAuthor);
                Console.WriteLine(item.BlogContent);
            }

        }

        //edit

        public void Edit(int id)
        {
            string query = "select * from tbl_blog where BlogId = @BlogId";
            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            var item = db.Query<BlogModel>(query, new {blogId = id}).FirstOrDefault();

            if( item is null )
            {
                Console.WriteLine("No Data Found");
                return;
            }

            Console.WriteLine(item.BlogId);
            Console.WriteLine(item.BlogTitle);
            Console.WriteLine(item.BlogAuthor);
            Console.WriteLine(item.BlogContent);




        }

        //creat

        public void Creat(string title, string author, string content)
        {

            string query = @"INSERT INTO [dbo].[Tbl_Blog]
           ([BlogTitle]
           ,[BlogAuthor]
           ,[BlogContent])
     VALUES
           (@BlogTitle
           ,@BlogAuthor
           ,@BlogContent)";

            BlogModel blog = new BlogModel()
            {
                BlogTitle =title,
                BlogAuthor = author,
                BlogContent = content
            };
            
            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            var result = db.Execute(query,blog);
            Console.Write( result > 0 ? "Saving Successful. " : "Saving Failed.");


        }

        //update
        public void Update(int id, string title, string author, string content)
        {
            
            string query = @"UPDATE [dbo].[Tbl_Blog]
   SET [BlogTitle] = @BlogTitle
      ,[BlogAuthor] = @BlogAuthor
      ,[BlogContent] = @BlogContent
 WHERE BlogId = @BlogId";
            BlogModel blog = new BlogModel()
            {
                BlogId = id,
                BlogTitle = title,
                BlogAuthor = author,
                BlogContent = content
            };

            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            var result = db.Execute(query, blog);
            Console.Write(result > 0 ? "Updating Successful. " : "Updating Failed.");


        }

        //delete

        public void Delete(int id)
        {
            
            string query = @"DELETE FROM [dbo].[Tbl_Blog]
      WHERE BlogId = @BlogId";
            BlogModel blog = new BlogModel()
            {
                BlogId = id,
                
            };

            using IDbConnection db = new SqlConnection(_sqlConnectionStringBuilder.ConnectionString);
            var result = db.Execute(query, blog);
            Console.Write(result > 0 ? "Deleting Successful. " : "Deleting Failed.");


        }


    }
}
