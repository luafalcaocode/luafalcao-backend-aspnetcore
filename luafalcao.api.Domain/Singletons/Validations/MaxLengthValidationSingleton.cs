using System;
using System.Collections.Generic;

namespace luafalcao.api.Domain.Singletons.Validations
{
    public class MaxLengthValidationSingleton : ISingleton
    {
        private static MaxLengthValidationSingleton _instance = new MaxLengthValidationSingleton();

        private MaxLengthValidationSingleton()
        {
        }

        public static MaxLengthValidationSingleton GetSingleton()
        {
            if (_instance == null)
            {
                return new MaxLengthValidationSingleton();
            }

            return _instance;
        }

        public IList<string> Validate<T>(T model)
        {

            IList<string> messages = new List<string>();

            foreach (var prop in model.GetType().GetProperties())
            {
                if (prop.Name.Equals("Autor") && Convert.ToString(prop.GetValue(model, null)).Length > 100)
                {
                    messages.Add($"O campo {prop.Name} não pude ultrapassar 100 caracteres");
                }
                else if (prop.Name.Equals("Email") && Convert.ToString(prop.GetValue(model, null)).Length > 30)
                {
                    messages.Add($"O campo {prop.Name} não pude ultrapassar 30 caracteres");
                }
                else if (prop.Name.Equals("Descricao") && Convert.ToString(prop.GetValue(model, null)).Length > 300)
                {
                    messages.Add($"O campo {prop.Name} não pude ultrapassar 300 caracteres");
                }
            }

            return messages;
        }
    }
}

