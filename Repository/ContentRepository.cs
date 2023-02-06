using MyBlog.Model;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Repository
{
    public class ContentRepository 
    {
        

        public CustomResponse AddContent()
        {
            using IDbConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ConnectionStrings"].ConnectionString);
            connection.Open();
            using var transaction = connection.BeginTransaction();

        }
    }
}
