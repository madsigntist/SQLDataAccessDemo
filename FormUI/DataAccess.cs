using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace FormUI
{
    public class DataAccess
    {
        public List<Product> GetProduct(string itemNumber)
        {
            using IDbConnection connection = new SqlConnection(Helper.CnnVal("CRUDwinformProductDemo"));
            {            
                var output = connection.Query<Product>($"select * from Product where ItemNumber = '{ itemNumber }'").ToList();
                //var output = connection.Query<Product>("dbo.spProduct_Get @ItemNumber", new { ItemNumber = itemNumber }).ToList();
                return output;
            }
        }

        public void InsertProduct(string itemNumber, string itemDescription)
        {
            using IDbConnection connection = new SqlConnection(Helper.CnnVal("CRUDwinformProductDemo"));
            {
                List<Product> products = new List<Product>();
                products.Add(new Product { ItemNumber = itemNumber, ItemDescription = itemDescription });
                connection.Execute("dbo.spProduct_Insert @ItemNumber, @ItemDescription", products );
            }
        }

        public List<Product> GetProducts()
        {
            using IDbConnection connection = new SqlConnection(Helper.CnnVal("CRUDwinformProductDemo"));
            {
                var output = connection.Query<Product>("dbo.spProduct_GetAll").ToList();
                return output;
            }
        }

        public void DeleteProduct(string itemNumber)
        {
            using IDbConnection connection = new SqlConnection(Helper.CnnVal("CRUDwinformProductDemo"));
            {          
                //connection.Execute("dbo.spProduct_Delete @ItemNumber", new { ItemNumber = itemNumber });
                connection.Execute($"delete from Product where ItemNumber = '{ itemNumber }'");
            }
        }
    }
}
