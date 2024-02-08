using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNetCoreDemo.Models
{
    public interface IUserDatabaseSettings
    {
        string CollectionName { get; set; }
        string ConnectionString { get; set; }
        string Database { get; set; }
    }
}