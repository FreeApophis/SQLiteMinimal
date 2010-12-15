using System.Data.SQLite;
using Database;

namespace SQLiteMinimal
{
    class Db
    {
        private static Main main = null;
        public static Main Main
        {
            get
            {
                return main ?? (main = new Main(new SQLiteConnection("Data Source=Example.s3db;FailIfMissing=true;")));
            }
        }
    }
}
