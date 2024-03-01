using Microsoft.Data.SqlClient;

namespace PoliziaMunicipale.Models
{
    public class DB
    {
        public static string connectionString = "server=LUPOPC117\\SQLEXPRESS; Initial Catalog=PoliziaMunicipale; Integrated Security=true; TrustServerCertificate=true";
        public static SqlConnection conn = new SqlConnection(connectionString);
    }
}
