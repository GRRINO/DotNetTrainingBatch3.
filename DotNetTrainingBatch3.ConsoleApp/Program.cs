// See https://aka.ms/new-console-template for more information
using DotNetTrainingBatch3.ConsoleApp.AdoDotNetExamples;
using DotNetTrainingBatch3.ConsoleApp.DapperExamples;
using DotNetTrainingBatch3.ConsoleApp.EFCoreExamples;
using System.Data;
using System.Data.SqlClient;

Console.WriteLine("Hello, World!");

//ctrl + k , c => disable
//ctrl + k + u => enable


#region Read
//SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder();
//sqlConnectionStringBuilder.DataSource = "DESKTOP-G92HAN0\\SQLEXPRESS01";
//sqlConnectionStringBuilder.InitialCatalog = "TestDb";
//sqlConnectionStringBuilder.UserID = "sa";
//sqlConnectionStringBuilder.Password = "yy@79250";

//Console.WriteLine(sqlConnectionStringBuilder.con);
//string query = "select * from tbl_blog";
//SqlConnection sqlConnection = new SqlConnection(sqlConnectionStringBuilder.ConnectionString);
//sqlConnection.Open();

//SqlCommand cmd = new SqlCommand(query,sqlConnection);
//SqlDataAdapter adapter = new SqlDataAdapter(cmd);
//DataTable dt =new DataTable();
//adapter.Fill(dt);
//sqlConnection.Close();

////dataset
////datatable
////datarow
////datacolumn


//foreach (DataRow dr in dt.Rows)
//{
//    Console.WriteLine(dr["BlogId"]);
//    Console.WriteLine(dr["BlogTitle"]);
//    Console.WriteLine(dr["BlogAuthor"]);
//    Console.WriteLine(dr["BlogContent"]);
//}

#endregion

Console.WriteLine();

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.read();
//adoDotNetExample.Edit(1);
//adoDotNetExample.Edit(0);
//adoDotNetExample.Creat("test title","test author","test content");
//adoDotNetExample.Update(2, "tt", "ta", "tc");

//adoDotNetExample.Delete(13);

DapperExample dapperExample = new DapperExample();
//dapperExample.Creat("yy", "yy2", "yy3");
//dapperExample.Delete(15);
//dapperExample.read();
//dapperExample.Edit(15);
//dapperExample.Edit(20);
//dapperExample.Update(15, "yyy", "yyy2", "yyy3");

EFCoreExample efCoreExample = new EFCoreExample();
//efCoreExample.creat("yyy", "yyy2", "yyy3");
//efCoreExample.delete(16);
//efCoreExample.read();
//efCoreExample.edit(2);
//efCoreExample.edit(23);
Console.ReadLine();