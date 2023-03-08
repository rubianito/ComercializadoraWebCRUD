namespace Domain.Requests
{
    public class FindProductsByCategory
    {
        public int CategoryId { get; set; }
        public bool OrderByName { get; set; }
        public bool NameAscending { get; set; }
        public bool OrderByDescription { get; set; }
        public bool DescriptionAscending { get; set; }
    }
}
