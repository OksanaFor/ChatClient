using DataTransferObjects.DTO;
using System;


namespace ChatClient.View.Interfaces
{
    public interface IForm1
    {
        event Action<string, string> OnAutorization;
        event Action<UserDTO> OnRegistration;
        void Enter();
        void ShowNotification(string message);

    }
    
}
