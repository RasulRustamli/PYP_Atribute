using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PYP_Atribute_Pratice.Validator
{
    public class ValidatorService<T> where T : class
    {
        public string AttributeCheck(T entity,Type type)
        {
            List<PropertyInfo> propertyInfos= entity.GetType().GetRuntimeProperties().Where(x => Attribute.IsDefined(x, type)).ToList();

            foreach(PropertyInfo propertyInfo in propertyInfos)
            {
                var result= propertyInfo.GetValue(entity).ToString();
                if (type.Name == "ValidEmail")
                {
                    if (!CustomValidation.MailCheck(result))
                        return "Please correct enter email";
                }
                else if (type.Name =="ValidPassword")
                {
                    if (!CustomValidation.PasswordCheck(result))
                        return "please correct password format";
                }
                
            }
            return "Correct";
        }
    }
}
