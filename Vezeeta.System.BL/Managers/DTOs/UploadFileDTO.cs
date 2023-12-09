namespace Vezeeta.System.APIs;

public class UploadFileDTO
{
    public bool IsSuccess { get; set; }
    public string Message { get; set; }
    //default value is empty string in case of bad request
    public string URL { get; set; }

    public UploadFileDTO(bool isSuccess, string message, string url = "")
    {
        IsSuccess = isSuccess;
        Message = message;
        URL = url;
    }
}
