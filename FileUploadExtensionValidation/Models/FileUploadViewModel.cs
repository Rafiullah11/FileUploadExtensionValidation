using FileUploadExtensionValidation.Utilities;
using System.ComponentModel.DataAnnotations;

namespace FileUploadExtensionValidation.Models
{
    public class FileUploadViewModel
    {
        [Required(ErrorMessage = "Please enter file name")]
        public string FileName { get; set; }
       
        [Required(ErrorMessage = "Please select file")]
        [CustomFileExtension(new string[] { "docx","pdf" }, ErrorMessage = "file extension must be docx, pdf")]
        public IFormFile File { get; set; }
    }
}
