using System;
using System.Collections.Generic;

namespace luafalcao.api.Domain.Singletons.Validations
{
    public interface ISingleton
    {
        IList<string> Validate<T>(T model);
    }
}
