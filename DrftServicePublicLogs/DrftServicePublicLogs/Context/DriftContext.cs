using DriftService.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DriftService.Context
{
    public class DriftContext :DbContext
        
    {
        public DriftContext() : base("DriftServiceDb")
        {
           
        }
        public DbSet<ServiceType> ServiceTypes { get; set; }
        public DbSet<Log> Logs { get; set; }
    }
}