namespace HelpingHands.Responses
{
    public class Response<T>
    {
        public int StatusCode;
        public string Message;
        public T? Data;
        public Response(int code,string message,T data) 
        {
            StatusCode = code;
            Message = message;
            Data = data;
        }
        public Response(int code, string message)
        {
            StatusCode = code;
            Message = message;
            Data = default(T);
        }
    }
}
