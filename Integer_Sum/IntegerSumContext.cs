using Microsoft.EntityFrameworkCore;

namespace Integer_Sum
{
    public class IntegerSumContext :DbContext
    {
        public IntegerSumContext(DbContextOptions<IntegerSumContext> options):base(options) { 
        }
        public DbSet<IntegerSum> IntegerSums { get; set; }
    }
}
