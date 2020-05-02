using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Tenant
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Host { get; set; }
        public string ConnectionString { get; set; }
        public string UniqueId { get; set; }
    }
}
