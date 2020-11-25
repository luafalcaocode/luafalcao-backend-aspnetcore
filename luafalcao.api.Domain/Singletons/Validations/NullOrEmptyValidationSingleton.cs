using System;
using System.Collections.Generic;
using System.Reflection;
using luafalcao.api.Persistence.Entities;

namespace luafalcao.api.Domain.Singletons.Validations
{
    public class NullOrEmptyValidationSingleton : ISingleton
    {
        private static NullOrEmptyValidationSingleton _instance = new NullOrEmptyValidationSingleton();

        private NullOrEmptyValidationSingleton()
        {
        }

        public static NullOrEmptyValidationSingleton GetSingleton()
        {
            if (_instance == null)
            {
                return new NullOrEmptyValidationSingleton();
            }

            return _instance;
        }

        public IList<string> Validate<T>(T model)
        {
            IList<string> messages = new List<string>();      

            foreach (var prop in model.GetType().GetProperties())
            {                
                var value = Convert.ToString(prop.GetValue(model, null));
                if (string.IsNullOrEmpty(value))
                {
                    messages.Add($"o campo {prop.Name} está vazio e precisa ser preenchido.");
                }                                                              
            }

            return messages;
        }
    }
}
