using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDeneme.DAL
{
    
    public class DbContextInitializer
    {
        public static IConfigurationRoot configuration;
        public static DbContextOptionsBuilder<AppDbContext> optionsBuilder;
       
    }
}
