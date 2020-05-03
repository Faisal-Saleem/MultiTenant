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
            /*  
             *  httpContextAccessor.HttpContext.Request.Host.Host returns only the host name e.g. test1.com
             *  if port number is required, httpContextAccessor.HttpContext.Request.Host.Value will return hostname:portnumber test1.com:5000
             */

            return tenantDbContext.Tenants.FirstOrDefault(tenant => tenant.Host == httpContextAccessor.HttpContext.Request.Host.Host);
        }
    }
}
