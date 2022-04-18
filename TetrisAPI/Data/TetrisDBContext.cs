using TetrisAPI.Models;
using Microsoft.EntityFrameworkCore;

namespace TetrisAPI.Data{
    public class TetrisAPIDbContext: DbContext{
        public TetrisAPIDbContext(DbContextOptions<TetrisAPIDbContext> opt):base(opt){
            
        }
        public DbSet<TetrisCore> tetris{get;set;}
        
    }
}
