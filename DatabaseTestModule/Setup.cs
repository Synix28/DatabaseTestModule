using GmodNET.API;
using MySqlConnector;

namespace DatabaseTestModule
{
    public class Setup : IModule
    {
        public string ModuleName => "DatabaseTestModule";

        public string ModuleVersion => "0.0.1";

        public void Load(ILua lua, bool is_serverside, ModuleAssemblyLoadContext assembly_context)
        {
            var builder = new MySqlConnectionStringBuilder
            {
                Server = "localhost",
                UserID = "root",
                Password = "",
                Database = "test",
                Pooling = false
            };

            MySqlConnection con = new MySqlConnection(builder.ConnectionString);
            con.Open();

            con.Close();
            con.Dispose();
        }

        public void Unload(ILua lua)
        {
        }
    }
}