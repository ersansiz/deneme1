using Dapper.Contrib.Extensions;
using deneme12.Entity;
using Microsoft.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;

namespace deneme12.Repostories
{
    public class DPOgrenciReporstory
    {
        public List<Ogrenci> GetirHepsi()
        {
            using var connection = new SqlConnection("Server=DESKTOP-O85AGKQ\\SQLEXPRESS; Database=Deneme12; Trusted_Connection=True; MultipleActiveResultSets=true");
            return connection.GetAll<Ogrenci>().ToList();
        }
    }
}
