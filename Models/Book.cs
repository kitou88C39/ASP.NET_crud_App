namespace asp.net_traning.Models;

public class Book {
{
    public int Id { get; set; }
    public string Title { get; set; }
    public string Author { get; set; }

    public string ISBN { get; set; }

    public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
}
}