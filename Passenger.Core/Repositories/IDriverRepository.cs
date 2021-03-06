using System;
using System.Collections.Generic;
using Passenger.Core.Domain;

namespace Passenger.Core.Repositories
{
    public interface IDriverRepository
    {
         Driver Get(Guid userid);
         IEnumerable<Driver> GetAll();
         void Add(Driver driver);
         void Update(Driver driver);
     }
}