namespace IdesseCaseStudy.Models;
public class CardListRequest
{
    public int Limit { get; set; }
    public int Start { get; set; }
    public bool IncludeVisitStats { get; set; }
}
