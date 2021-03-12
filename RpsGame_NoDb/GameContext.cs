

public class GamingContext : DbContext
{
    public DbSet<Player> Players { get; set;}
}
