using Refit;
using IdesseCaseStudy.Models;

namespace IdesseCaseStudy.Services;

public interface IInfiniApi
{
    [Post("/Account/Login")]
    Task<Refit.ApiResponse<Models.ApiResponse<LoginResult>>> Login([Body] LoginRequest request); 

    [Get("/Account/GetUserMobile")]
    Task<Refit.ApiResponse<Models.ApiResponse<UserDto>>> GetUserMobile();

    [Post("/Card/GetListMobile")]
    Task<Refit.ApiResponse<CardListResult>> GetCardList([Body] CardListRequest request);
}
