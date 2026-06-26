public class BaseResponse<T>(string message, bool status, T data)
{
    public string Message = message;
    public bool Status = status;
    public T Data = data;

}