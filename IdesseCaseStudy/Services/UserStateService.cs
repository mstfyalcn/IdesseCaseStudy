 
using IdesseCaseStudy.Models; 

namespace IdesseCaseStudy.Services;

public class UserStateService
{
    public UserDto CurrentUser { get; private set; }

    public void SetUser(UserDto user)
    {
        CurrentUser = user;
    }
    public List<Card> LocalCards { get; set; } = new();

    public void AddCardLocally(Card card)
    { 
        LocalCards.Insert(0, card);
    }
    public bool IsLoggedIn => CurrentUser != null;
    public void Clear()
    {
        CurrentUser = null;
        LocalCards.Clear();
    }
}

