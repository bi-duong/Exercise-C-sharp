using Npgsql;

namespace DAL
{
    public class DatabaseAccess
    {
        protected NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Database=\"LAB_DATABASE CONNECTION_CSHARP_4LABS\";Password=DvBI@185101");
    }
}