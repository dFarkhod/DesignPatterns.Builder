using System.Data.SqlClient;
using System.Text;
using VirtualDars.DesignPatterns.Builder;
using static System.Console;

// an'anaviy builder
var coffeeDirector = new CoffeeDirector();

var cappucinoBuilder = new CappucinoBuilder();
var coffee = coffeeDirector.MakeCoffee(cappucinoBuilder);
WriteLine(coffee.Show());
WriteLine();

var mochaBuilder = new MochaBuilder();
var coffee2 = coffeeDirector.MakeCoffee(mochaBuilder);
WriteLine(coffee2.Show());
WriteLine();


// fluent builder
var fluentCoffeeDirector = new FluentCoffeeDirector();

var fluentCappBuilder = new FluentCappucinoBuilder();
var coffee3 = fluentCoffeeDirector.MakeCoffee(fluentCappBuilder);
WriteLine(coffee3.Show());
WriteLine();

var fluentMochaBuilder = new FluentMochaBuilder();
var coffee4 = fluentCoffeeDirector.MakeCoffee(fluentMochaBuilder);
WriteLine(coffee4.Show());
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