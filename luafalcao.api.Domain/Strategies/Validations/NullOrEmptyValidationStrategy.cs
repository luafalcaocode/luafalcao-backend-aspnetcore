using System;
using System.Collections.Generic;
using System.Reflection;
using luafalcao.api.Persistence.Entities;

namespace luafalcao.api.Domain.Strategies.Validations
{
    public class NullOrEmptyValidationStrategy<T> : IValidationStrategy<T>
    {
        private static NullOrEmptyValidationStrategy<T> _instance = new NullOrEmptyValidationStrategy<T>();

        private NullOrEmptyValidationStrategy()
        {
        }

        public static IValidationStrategy<T> GetSingleton()
        {
            if (_instance == null)
            {
                return new NullOrEmptyValidationStrategy<T>();
            }

            return _instance;
        }

        public IList<string> Validate(T model)
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
