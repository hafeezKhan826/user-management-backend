using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Models
{
    public class UserDatabaseSettings : IUserDatabaseSettings
    {
        public string CollectionName { get; set; } = String.Empty;
        public string ConnectionString { get; set; } = String.Empty;
        public string Database { get; set; } = String.Empty;
    }
}