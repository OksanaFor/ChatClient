using ChatClient.View.Interfaces;
using DataTransferObjects.DTO.Requests;
using DataTransferObjects.DTO;
using System.Windows.Forms;
using System;
using ChatClient.DataServer;

namespace ChatClient.Presenter
{
    public class Form1Presenter
    {
        private readonly DBUserService _userDBServies = new DBUserService();
        private readonly IForm1 _view;

        public Form1Presenter(IForm1 view)
        {
            _view = view;
            _view.OnAutorization += AuthorizationAsync;
            _view.OnRegistration += RegistrationAsync;

        }
        private async void AuthorizationAsync(string login, string password)
        {
            try
            {
                AuthorizationDto autorDto = new AuthorizationDto
                {

                    Login = login,
                    Password = password
                };
                await _userDBServies.AuthorizadeUser(autorDto);

            }
            catch (Exception ex)
            {
                _view.ShowNotification(ex.Message);
            }

        }

        private async void RegistrationAsync(UserDTO user)
        {
            try
            {
            
                await _userDBServies.RegistrationUser(user);
                _view.Enter();
            }
            catch (Exception ex)
            {
                _view.ShowNotification(ex.Message);
            }

        }
    }
}