
namespace V2_Biblioteca
{
    internal class ConexaoString
    {
        string serverName = "localhost"; // ou 127.0.0.1
        string port = "5432"; // porta default
        string userName = "postgres"; // nome da conta de administrador
        string password = "admin"; // senha do SGBD
        string dataBaseName = "bdBiblioteca"; // nome do BD

        public string ConnString()
        {
            var connString = $"Server = {serverName};Port = {port};Username = {userName};Password = {password};Database = {dataBaseName};";
            return connString;
        }
    }
}
