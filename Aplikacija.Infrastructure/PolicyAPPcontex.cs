using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Aplikacija.Core;

namespace Repository
{
    public class PolicyAPPcontext : DbContext
    {
        public PolicyAPPcontext() : base("name=PolicyAPPdbcopy") { }
        //public DbSet Beneficiary { get; set; }
        //public DbSet Contractor { get; set; }
        //public DbSet Insured { get; set; }
        //public DbSet Policy { get; set; }
        //public DbSePolicyViewModelst Vehicle { get; set; }
        //public DbSet Franshiza { get; set; }


        public System.Data.Entity.DbSet<Domain.Beneficiary> Beneficiaries { get; set; }

        public System.Data.Entity.DbSet<Domain.Contractor> Contractors { get; set; }

        public System.Data.Entity.DbSet<Domain.Insured> Insureds { get; set; }

        public System.Data.Entity.DbSet<Domain.Vehicle> Vehicles { get; set; }

        public System.Data.Entity.DbSet<Domain.Policy> Policies { get; set; }

        public System.Data.Entity.DbSet<Franshiza> Franshizas { get; set; }
        public System.Data.Entity.DbSet<Package> Packages { get; set; }
        public System.Data.Entity.DbSet<Tipkind> Tipkinds { get; set; }
        public System.Data.Entity.DbSet<Valute> Valutes { get; set; }

        //public System.Data.Entity.DbSet<Aplikacija.Core.PolicyViewModel> PolicyViewModels { get; set; }

        //public System.Data.Entity.DbSet<Aplikacija.Core.PolicyViewModel> PolicyViewModels { get; set; }
    }
    }
