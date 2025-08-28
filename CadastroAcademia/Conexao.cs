using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;


namespace CadastroAcademia
{
    internal class Conexao
    {
        private static readonly string stringConexao = ConfigurationManager.ConnectionStrings["DB_ACAD"].ConnectionString;

        public static SqlConnection ObterConexao()
        {
            return new SqlConnection(stringConexao);
        }
    }
}
