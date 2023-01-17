using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DatabaseAccess
    {
        protected NpgsqlConnection connection = new NpgsqlConnection("Host=localhost;Username=postgres;Database=\"LAB_DATABASE CONNECTION_CSHARP_4LABS\";Password=DvBI@185101");
    }
}
