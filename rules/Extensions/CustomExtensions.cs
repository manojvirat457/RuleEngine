using DynamicExpresso;
using Core.Exceptions;
using Core.Models;
using System.Reflection;
using System.Dynamic;

namespace Core.Extensions
{
    public static class CustomExtensions
    {
        public static dynamic DictionaryToObject(this Dictionary<String, Object> dictionary)
        {
            var expandoObj = new ExpandoObject();
            var expandoObjCollection = (ICollection<KeyValuePair<String, Object>>)expandoObj;

            foreach (var keyValuePair in dictionary)
            {
                expandoObjCollection.Add(keyValuePair);
            }
            dynamic eoDynamic = expandoObj;
            return eoDynamic;
        }

    }
}
