using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace NTHBaiThucHanh513.Models
{
    public partial class ltqlDBcontext : DbContext
    {
        public ltqlDBcontext() : base("name =ltqlDBcontext") { }
        public virtual DbSet<Khoa> Khoas { get; set; }
        public virtual DbSet<Student> Students { get; set; }

    }
}