using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChatClient.DataServer
{
    public static class ServerInfo
    {
        //public static string Host = "http://game.somee.com/";
        public static string Host = "https://localhost:7059/";

        #region Controllers
        public static string User = nameof(User);
        public static string Message = nameof(Message);
 

        #endregion

        #region Methods


        #region Base
        public static string GetAll = nameof(GetAll);
        public static string GetById = nameof(GetById);
        public static string Update = nameof(Update);
        public static string Create = nameof(Create);
        public static string Delete = nameof(Delete);
        #endregion

        #region UserController
        public static string Registration = nameof(Registration);
        public static string Authorization = nameof(Authorization);
        public static string GetUsersOnLocation = nameof(GetUsersOnLocation);
        public static string GetFriends = nameof(GetFriends);
        public static string InviteFriend = nameof(InviteFriend);
        #endregion



        #region MessageController
        public static string GetMessage = nameof(GetMessage);
        #endregion
        #endregion



        public static string CreateRequestURL(string host, string controller, string method) => host + controller + "/" + method;
    }
}
