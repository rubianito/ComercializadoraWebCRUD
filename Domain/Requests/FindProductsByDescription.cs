namespace Domain.Requests
{
    public class FindProductsByDescription
    {
        public string ProductDescription { get; set; }
        public bool OrderByName { get; set; }
        public bool NameAscending { get; set; }
    }
}
