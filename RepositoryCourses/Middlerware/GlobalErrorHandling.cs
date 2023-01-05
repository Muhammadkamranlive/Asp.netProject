using Newtonsoft.Json;
using System.Globalization;

namespace RepositoryCourses.Middlerware
{
    public class GlobalErrorHandling
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public override string ToString()=> JsonConvert.SerializeObject(this);
      

    }
}
