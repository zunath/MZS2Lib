using System.Data.Entity;

namespace MZS2ServerLib
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public partial class MZS2Context : DbContext
    {
        public MZS2Context(string connectionString)
            : base(connectionString)
        {
        }
    }
}
