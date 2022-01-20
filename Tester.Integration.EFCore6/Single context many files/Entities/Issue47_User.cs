// <auto-generated>

using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Tester.Integration.EFCore6.Single_context_many_files
{
    // Users
    public class Issue47_User
    {
        public int UserId { get; set; } // UserId (Primary key)
        public string Name { get; set; } // Name (length: 10)

        // Reverse navigation

        /// <summary>
        /// Child Issue47_UserRoles where [UserRoles].[UserId] point to this entity (Issue47_UserRoles_userid)
        /// </summary>
        public virtual ICollection<Issue47_UserRole> Issue47_UserRoles { get; set; } // UserRoles.Issue47_UserRoles_userid

        public Issue47_User()
        {
            Issue47_UserRoles = new List<Issue47_UserRole>();
        }
    }

}
// </auto-generated>
