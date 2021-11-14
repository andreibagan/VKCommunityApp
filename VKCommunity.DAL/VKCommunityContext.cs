using Microsoft.EntityFrameworkCore;
using VKCommunity.DAL.Models;

namespace VKCommunity.DAL
{
    public class VKCommunityContext : DbContext
    {
        public VKCommunityContext(DbContextOptions<VKCommunityContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<Community> Communities { get; set; }
        public DbSet<UserCommunity> UserCommunities { get; set; }
        public DbSet<PostMessage> PostMessages { get; set; }
    }
}
