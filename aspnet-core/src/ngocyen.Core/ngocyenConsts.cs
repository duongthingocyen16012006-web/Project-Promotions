using ngocyen.Debugging;

namespace ngocyen
{
    public class ngocyenConsts
    {
        public const string LocalizationSourceName = "ngocyen";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "0649a1aeb51a412f8794d723b9f915b2";
    }
}
