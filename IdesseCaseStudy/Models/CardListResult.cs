namespace IdesseCaseStudy.Models;
public class CardListResult
{
    public bool success { get; set; }
    public List<Card> data { get; set; }
}

public class Card
{
    public int CardId { get; set; }
    public string CardTitleCode { get; set; }
    public string CardName { get; set; }
    public bool CardIsMale { get; set; }
    public string CardProfessionCode { get; set; }
    public string LocationName { get; set; }
    public int ThisMonthPlanCount { get; set; }
    public int YtdPlanCount { get; set; }
    public double RealizedCountAvg { get; set; }
    public string PropertySegment { get; set; }
}