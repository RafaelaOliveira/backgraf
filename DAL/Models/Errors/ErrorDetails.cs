using Newtonsoft.Json;

namespace back_pi.Controllers.Errors
{
    public class ErrorDetails
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
 
 
        public override string ToString()
        {
            return JsonConvert.SerializeObject(this);
        }
    }
}