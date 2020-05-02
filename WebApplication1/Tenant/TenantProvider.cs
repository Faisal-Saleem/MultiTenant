using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Tenant
{
    public class TenantProvider : ITenantProvider
    {
        // Tenant Database context
        public TenantDbContext tenantDbContext {get;}

        // To access request headers to identify host name
        public IHttpContextAccessor httpContextAccessor { get; }
        public TenantProvider(TenantDbContext tenantDbContext, IHttpContextAccessor httpContextAccessor)
        {
            this.tenantDbContext = tenantDbContext;
            this.httpContextAccessor = httpContextAccessor;
        }
        public Tenant GetTenant()
        {
            return tenantDbContext.Tenants.FirstOrDefault(tenant => tenant.Host == httpContextAccessor.HttpContext.Request.Host.Host);
        }
    }
}
