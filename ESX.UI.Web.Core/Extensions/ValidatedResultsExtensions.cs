using System.Collections.Generic;
using FluentValidation.Results;

namespace ESX.UI.Web.Core.Extensions
{
    public static class ValidatedResultsExtensions
    {
        public static string[] GetErros(this ValidationResult validationResult)
        {
            var result = new List<string>();

            if (validationResult != null && validationResult.Errors != null)
                foreach (var error in validationResult.Errors)
                    result.Add(error.ErrorMessage);
            return result.ToArray();
        }
    }
}
