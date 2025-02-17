﻿using Eazii_Foods.Models;
using Eazii_Foods.ViewModel;

namespace Eazii_Foods.IHelper
{
    public interface IUserHelper
    {
        Task<ApplicationUser> FindByUserNameAsync(string username);
        ApplicationUser FindByUsername(string username);
        string GetUserById(string username);
        Task<ApplicationUser> FindUserByEmail(string email);
        Task<ApplicationUser> FindUserByIdAsync(string?id);
        ApplicationUser FindByEmail(string email);
        Task<ApplicationUser> ChefsRegistertion(ApplicationUserViewModel applicationUserViewModel);
        Task<ApplicationUser> FindByUserEmailAsync(string username);
        Task<List<State>> GetState();
        List<FoodViewModel> GetLisstOfFood();
        FoodViewModel GetFoodByFoodId(int id);
        List<ChefsViewModel> ListOfChefs();
        bool AddFood(FoodViewModel foodViewModel, string base64);
        string EditFood(FoodViewModel foodViewModel);
        string DeleteFood(int id);
        string UploadedFile(IFormFile filesUrl, string fileLocation);
        string FoodCreate(ChefsViewModel foods);
        string GetRoleLayout(string username);
        Task<bool> CheckIfUserIsAdmin(string username);
        Task<ApplicationUser> CreateAdminAsync(ApplicationUserViewModel model);
        ChefsViewModel GetAllChefs();


        //Task<List<ChefsViewModel>> GetAllChefsAsync();      
        //Task<List<Food>> GetFood();

    }
}
