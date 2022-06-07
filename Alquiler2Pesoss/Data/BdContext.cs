using Microsoft.EntityFrameworkCore;

namespace Alquiler2Pesoss.Data
{
    public class BdContext :DbContext
    {
        public BdContext(DbContextOptions<BdContext> options) : base(options) { }

        

    }
}
