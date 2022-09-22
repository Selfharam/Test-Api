using NpgsqlTypes;
using System.ComponentModel.DataAnnotations.Schema;

namespace TestApi
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }
        public string family { get; set; }
        
        public DateTime date_birth { get; set; }
    }
}
