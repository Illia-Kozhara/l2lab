using L2Lab.Debugging;

namespace L2Lab
{
    public class L2LabConsts
    {
        public const string LocalizationSourceName = "L2Lab";

        public const string ConnectionStringName = "Default";

        public const bool MultiTenancyEnabled = true;


        /// <summary>
        /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
        /// </summary>
        public static readonly string DefaultPassPhrase =
            DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "edc8e545e9404ff1aadb762ec050e34e";
    }
}
