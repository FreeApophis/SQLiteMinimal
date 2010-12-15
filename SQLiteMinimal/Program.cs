using System.Linq;
using Database;

namespace SQLiteMinimal
{
    class Program
    {
        static void Main()
        {
            
            var value = new KeyValue { Key = "Key1", Value = "Value1" };

            Db.Main.KeyValues.InsertOnSubmit(value);
            Db.Main.SubmitChanges();

            System.Console.WriteLine(Db.Main.KeyValues.Where(p => p.Key == "Key1").Count());
            System.Console.ReadLine();
        }
    }
}
