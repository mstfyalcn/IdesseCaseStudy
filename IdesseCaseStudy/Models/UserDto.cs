namespace IdesseCaseStudy.Models;
public class UserDto
{
    public string UserId { get; set; }
    public string CurrentUserId { get; set; }
    public int CardId { get; set; }
    public string UserName { get; set; }
    public string FullName { get; set; }
    public string EMail { get; set; }
    public string PozisyonAçıklaması { get; set; }
    public string UygulamaRolü { get; set; }
    public bool IsAdmin { get; set; }
    public int SorumlulukBirimTürü { get; set; }
    public int SorumlulukBirimKimliği { get; set; }
    public int ÜstSorumlulukBirimKimliği { get; set; }
    public int İşBirimKimliği { get; set; }
    public int OrganizationId { get; set; }
    public List<int> ProductIds { get; set; }
    public string EtkinSeçimSüresiKodu { get; set; }
    public string LensConnection { get; set; }
    public int ExternalUserType { get; set; }
    public string? PositionDescription { get; set; }
}

