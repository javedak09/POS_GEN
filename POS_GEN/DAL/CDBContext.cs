using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using POS_GEN.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POS_GEN.DAL
{
    internal class CDBContext : DbContext
    {
        public CDBContext() : base("cnStr") { }
        
        public DbSet<MLogin> Users { get; set; }
    }
}