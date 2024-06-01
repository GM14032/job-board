namespace job_board.utils
{
    public class ErrorResponse
    {
        public string Status { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }

        public ErrorResponse(string message, int code)
        {
            Status = "error";
            Message = message;
            Code = code;
        }
    }
}
