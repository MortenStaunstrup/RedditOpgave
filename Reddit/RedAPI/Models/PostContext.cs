using System.Data.Common;
using Microsoft.EntityFrameworkCore;
using Core;
namespace RedAPI.Models;

public class PostContext : DbContext
{
    public DbSet<Post> Posts => Set<Post>();
    public DbSet<Comment> Comments => Set<Comment>();
    
    public PostContext(DbContextOptions<PostContext> options) 
        : base(options)
    {
        
    }
}