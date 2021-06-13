namespace API.Errors
{
    public class ApiResponse
    {
        public ApiResponse(int statusCode, string message = null)
        {
            StatusCode = statusCode;
            Message = message ?? GetDefaultMsgForStatusCode(statusCode);
        }

        public int StatusCode { get; set; }
        public string Message { get; set; }
        private string GetDefaultMsgForStatusCode(int code){
            return code switch{
                400 => "A bad request, you have made",
                401 => "Authorized, you are not",
                404 => "Resource found, it wat not",
                500 => "Errors are the path to the dark side. Errors lead to anger, Anger leads to hate. Hate leads to career change.",
                _ => null
            };
        }
    }
}