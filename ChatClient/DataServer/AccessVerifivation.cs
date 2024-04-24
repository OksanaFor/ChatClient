using DataTransferObjects.DTO;


namespace ChatClient.DataServer
{
    public class AccessVerifivation
    {
        public string Token { get; set; }
        public UserDTO CurrentUser { get; set; }
        public string OriginalPassword { get; set; }

        private static AccessVerifivation _instance;

        public static AccessVerifivation Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new AccessVerifivation();
                return _instance;
            }
        }

        public bool SuccessVerifivation() => Token != null;
    }
}
