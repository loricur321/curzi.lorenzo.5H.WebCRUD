#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using curzi.lorenzo._5H.WebCRUDE.Models;

    public class WebCRUDEContext : DbContext
    {
        public WebCRUDEContext (DbContextOptions<WebCRUDEContext> options)
            : base(options)
        {
        }

        public DbSet<curzi.lorenzo._5H.WebCRUDE.Models.Movie> Movie { get; set; }
    }
