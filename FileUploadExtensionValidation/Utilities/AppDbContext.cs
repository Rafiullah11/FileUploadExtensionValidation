using FileUploadExtensionValidation.Models;
using Microsoft.EntityFrameworkCore;

namespace FileUploadExtensionValidation.Utilities
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<FileUpload> FileUploads { get; set; }
}    }
