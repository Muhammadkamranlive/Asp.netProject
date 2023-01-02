namespace RepositoryCourses.Domain.Models.Authentication
{
    public class AuthResults
    {
        public string token { get; set; }
        public bool Result { get; set; }
        public List<string> Errors  { get; set; }
    }
}
