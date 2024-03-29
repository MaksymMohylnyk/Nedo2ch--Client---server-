﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Nedo2ch.Models
{
    public class ArticleContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }

        public ArticleContext(DbContextOptions<ArticleContext> options) : base(options)
        {
            Database.EnsureCreated();
        }
    }
}
