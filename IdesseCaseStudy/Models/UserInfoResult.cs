namespace IdesseCaseStudy.Models;
public class UserInfoResult
{
    public bool success { get; set; }
    public UserInfo data { get; set; }
}

public class UserInfo
{
    public int UserId { get; set; }
    public string UserName { get; set; }
    public string FullName { get; set; }
    public string EMail { get; set; }
}
