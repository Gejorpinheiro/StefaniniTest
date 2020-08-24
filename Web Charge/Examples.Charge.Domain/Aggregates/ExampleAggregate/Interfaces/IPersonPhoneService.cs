using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Examples.Charge.Domain.Aggregates.ExampleAggregate.Interfaces
{
    public interface IPersonPhoneService
    {
        Task<List<Example>> FindAllAsync();
    }
}
