using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Shared.ViewModel.Entities.Common;

namespace Shared.ViewModel.Entities
{
    public class UserModel : IdentityUser<long>, ISoftDelete //IdentityUser<long>, IHasCreationTime, IHasDeletionTime, ISoftDelete, IHasModificationTime
    {
        public string FirstName { get; set; } = null;
        public string MiddleName { get; set; } = null;
        public string LastName { get; set; } = null;
        public bool IsFirstTimeLogin { get; set; } = true;
        public bool IsDeleted { get; set; }
        public string FullName 
        { 
            get 
            {
                return $"{LastName} {FirstName}";
            }
        }
    }
}
