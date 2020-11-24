using System;
using System.Collections.Generic;
using luafalcao.api.Persistence.Entities;

namespace luafalcao.api.Domain.Strategies.Validations
{
    public interface IValidationStrategy<T>
    {
        IList<string> Validate(T model);
        
    }
}
