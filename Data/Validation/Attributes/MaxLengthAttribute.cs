using System.ComponentModel.DataAnnotations;

namespace EshopApi.Data.Validation.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class TruncateAttribute : ValidationAttribute
    {
        private readonly int _maxLength;

        public TruncateAttribute(int maxLength)
        {
            _maxLength = maxLength;
        }

        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            if (value is string stringValue && stringValue.Length > _maxLength)
            {
                //value = stringValue.Substring(0, _maxLength);
                value = stringValue[.._maxLength];
            }
            var property = validationContext.ObjectType.GetProperty(validationContext.MemberName);
            property.SetValue(validationContext?.ObjectInstance, value);

            return ValidationResult.Success;
        }
    }
}
