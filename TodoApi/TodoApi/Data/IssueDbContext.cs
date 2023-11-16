using Microsoft.EntityFrameworkCore;
using TodoApi.Models;

namespace TodoApi.Data {
    public class IssueDbContext : DbContext {
        public IssueDbContext(DbContextOptions<IssueDbContext> options) : base(options) {
        }

        public DbSet<Issue> Issues { get; set; }
    }
}
