namespace Domain.Requests
{
    public class FindProductsByName
    {
        public string ProductName { get; set; }
        public bool OrderByDescription { get; set; }
        public bool DescriptionAscending { get; set; }
    }
}
