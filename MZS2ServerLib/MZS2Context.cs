using System.Data.Entity;

namespace MZS2ServerLib
{
    public partial class MZS2Context : DbContext
    {
        public MZS2Context(string connectionString)
            : base(connectionString)
        {
        }
    }
}
