using System.Data.SqlClient;

namespace DAL
{
    public static class Conexion
    {
        private static string NombreAplicacion = "Prueba";
        private static string Servidor = @"SRG\SQL2019";
        private static string Usuario = "srg";
        private static string Password = "#Mejia#";
        private static string BaseDatos = "DinamicWeb";

        public static string ConexionString(bool SqlAutentication = true)
        {
            SqlConnectionStringBuilder Constructor = new SqlConnectionStringBuilder()
            {
                ApplicationName = NombreAplicacion,
                IntegratedSecurity = SqlAutentication,
                DataSource = Servidor,
                InitialCatalog = BaseDatos
            };

            if (SqlAutentication)
            {
                Constructor.UserID = Usuario;
                Constructor.Password = Password;
            }

            return Constructor.ConnectionString;
        }
    }
}
