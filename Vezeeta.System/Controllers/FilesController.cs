using Microsoft.AspNetCore.Mvc;
using Vezeeta.System.BL.DTOs.Files;

namespace Vezeeta.System.APIs.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilesController : ControllerBase
    {
        [HttpPost]
        public ActionResult<UploadFileDTO> Upload([FromForm] IFormFile file)
        {
            var newFileName = $"{Guid.NewGuid()}{Path.GetExtension(file.FileName)}";
            var imagesPath = Path.Combine(Environment.CurrentDirectory, "Images");
            var fullFilePath=Path.Combine(imagesPath, newFileName);

            #region checking extension            
            static bool FileHasAllowedExtension(string filePath, params string[] allowedExtensions)
            {
                if (string.IsNullOrEmpty(filePath) || allowedExtensions == null || allowedExtensions.Length == 0)
                {
                    return false; // Invalid arguments
                }

                try
                {
                    // Get the file extension (including the dot)
                    string fileExtension = Path.GetExtension(filePath);

                    // Check if the file extension is in the list of allowed extensions
                    foreach (var allowedExtension in allowedExtensions)
                    {
                        if (string.Equals(fileExtension, allowedExtension, StringComparison.OrdinalIgnoreCase))
                        {
                            return true; // Valid extension
                        }
                    }

                    return false; // Invalid extension
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"An error occurred: {ex.Message}");
                    return false;
                }
            }

            if (!FileHasAllowedExtension(fullFilePath, ".png", ".jpg", ".svg", ".webp"))
            {
                return BadRequest(new UploadFileDTO ( false, "extension is not valid"));
            }
            #endregion

            #region checking length

            //pic should be only up to 4MB
            bool isSizeAllowed = file.Length > 0 && file.Length <= 4_000_000;

            if (!isSizeAllowed)
            {
                return BadRequest(new UploadFileDTO(false, "picture size is too big"));
            }
            #endregion

            #region storing the image in the hard disk
            using var stream = new FileStream(fullFilePath, FileMode.Create);
            file.CopyTo(stream);
            #endregion

            #region generating the URL
            //https://localhost:7016/Images/photo.png
            var url = $"{Request.Scheme}://{Request.Host}/Images/{newFileName}";
            return new UploadFileDTO(true,"url generated successfully",url);
            #endregion
        }
    }
}
