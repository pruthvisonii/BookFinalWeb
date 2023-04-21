namespace BookShopAsp.Models
{
    public class ErrorViewModell
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}