using System.Data.SqlClient;
using System.Text;
using VirtualDars.DesignPatterns.Builder;
using static System.Console;

// an'anaviy builder
var teaDirector = new TeaDirector();

var lemonTeaBuilder = new LemonTeaBuilder();
var tea1 = teaDirector.MakeTea(lemonTeaBuilder);
WriteLine(tea1.Show());
WriteLine();

var greenTeaBuilder = new GreenTeaBuilder();
var tea2 = teaDirector.MakeTea(greenTeaBuilder);
WriteLine(tea2.Show());
WriteLine();


// fluent builder
var fluentTeaDirector = new FluentTeaDirector();

var fluentCappBuilder = new FluentLemonTeaBuilder();
var tea3 = fluentTeaDirector.MakeTea(fluentCappBuilder);
WriteLine(tea3.Show());
WriteLine();

var fluentBlackTeaBuilder = new FluentBlackTeaBuilder();
var tea4 = fluentTeaDirector.MakeTea(fluentBlackTeaBuilder);
WriteLine(tea4.Show());
WriteLine();



// Builder patterniga .Net dan misolllar: StringBuilder va SqlConnectionStringBuilder
var sb = new StringBuilder();
sb.Append("Salom");
sb.Append(" ");
sb.Append("Dunyo!");
WriteLine(sb.ToString());
WriteLine();


var cb = new SqlConnectionStringBuilder("Data Source=myServer;Initial Catalog=myDatabase;Integrated Security=True;");
var dbName = cb.InitialCatalog;
WriteLine(dbName);
cb.DataSource = "yourServer";
cb.InitialCatalog = "yourDatabase";
cb.IntegratedSecurity = false;
string updatedConnString = cb.ConnectionString;
Console.WriteLine(updatedConnString);
WriteLine();

ReadLine();