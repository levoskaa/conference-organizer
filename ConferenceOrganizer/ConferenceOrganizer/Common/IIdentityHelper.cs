using System.Collections.Generic;

namespace Web.Common
{
    public interface IIdentityHelper
    {
        int GetAuthenticatedUserId();

        IEnumerable<string> GetAuthenticatedUserRoles();
    }
}