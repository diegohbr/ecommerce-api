using MyEcommerceApp.Debugging;

namespace MyEcommerceApp
{
    public class MyEcommerceAppConsts
    {
        public const string LocalizationSourceName = "MyEcommerceApp";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "f328af899c484583a453e8d29c93984b";
    }
}
