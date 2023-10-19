using Microsoft.EntityFrameworkCore;

namespace Aspnet_traning.Data
{
    public class ApplicationDbContext:DbContext
    {

public ApplicationDbContext(DbContextOptions<ApplicationDbContext>options)
: base(options){
    
}

    }
}