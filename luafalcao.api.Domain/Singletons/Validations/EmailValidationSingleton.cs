using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using luafalcao.api.Domain.Singletons.Validations;

namespace luafalcao.api.Domain.Singletons.Validations
{
    public class EmailValidationSingleton : ISingleton
    {
        private static EmailValidationSingleton _instance = new EmailValidationSingleton();

        private EmailValidationSingleton()
        {
        }

        public static EmailValidationSingleton GetSingleton()
        {
            if (_instance == null)
            {
                return new EmailValidationSingleton();
            }

            return _instance;
        }

        public IList<string> Validate<T>(T model)
        {
            IList<string> messages = new List<string>();

            foreach (var prop in model.GetType().GetProperties())
            {
                if (prop.Name.ToUpper().Equals("EMAIL"))
                {
                    var value = Convert.ToString(prop.GetValue(model, null));
                    var emailRegExp = @"\A(?:[a-z0-9!#$%&'*+/=?^_`{|}~-]+(?:\.[a-z0-9!#$%&'*+/=?^_`{|}~-]+)*@(?:[a-z0-9](?:[a-z0-9-]*[a-z0-9])?\.)+[a-z0-9](?:[a-z0-9-]*[a-z0-9])?)\Z";

                    if (Regex.IsMatch(value, emailRegExp, RegexOptions.IgnoreCase) == false)
                    {
                        messages.Add("O endereço de e-mail informado não está no formato correto");
                        return  messages;
                    }
                }
            }

            return messages;
        }
    }
}
