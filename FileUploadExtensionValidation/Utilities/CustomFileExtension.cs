using System.ComponentModel.DataAnnotations;

namespace FileUploadExtensionValidation.Utilities
{
    public class CustomFileExtensionAttribute : ValidationAttribute
    {
        private readonly string[] allowedAttribute;

        public CustomFileExtensionAttribute(string[] allowedAttribute)
        {
            this.allowedAttribute = allowedAttribute;
        }
        public override bool IsValid(object value)
        {
            var file= value as IFormFile;
            string extension = Path.GetExtension(file.FileName);
            extension = extension.Trim('.');
            return allowedAttribute.Contains(extension);
        }
    }
}
