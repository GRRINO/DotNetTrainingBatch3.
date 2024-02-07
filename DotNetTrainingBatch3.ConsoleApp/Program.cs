// See https://aka.ms/new-console-template for more information
using DotNetTrainingBatch3.ConsoleApp.AdoDotNetExamples;
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

AdoDotNetExample adoDotNetExample = new AdoDotNetExample();
//adoDotNetExample.read();
//adoDotNetExample.Edit(1);
//adoDotNetExample.Edit(0);
//adoDotNetExample.Creat("test title","test author","test content");
//adoDotNetExample.Update(2, "tt", "ta", "tc");

//adoDotNetExample.Delete(13);

Console.ReadLine();