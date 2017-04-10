using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;

namespace CoreApplication.Policy
{
    public class HasPasswordHandler : AuthorizationHandler<LoginRequirement>
    {
        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, LoginRequirement requirement)
        {
            if (!context.User.HasClaim(c => c.Type == "UsernameAndPassword"))
                throw new NotImplementedException();
            throw new NotImplementedException();
        }
    }
}
