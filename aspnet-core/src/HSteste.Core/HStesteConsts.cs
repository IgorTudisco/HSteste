using HSteste.Debugging;

namespace HSteste;

public class HStesteConsts
{
    public const string LocalizationSourceName = "HSteste";

    public const string ConnectionStringName = "Default";

    public const bool MultiTenancyEnabled = true;


    /// <summary>
    /// Default pass phrase for SimpleStringCipher decrypt/encrypt operations
    /// </summary>
    public static readonly string DefaultPassPhrase =
        DebugHelper.IsDebug ? "gsKxGZ012HLL3MI5" : "ac16037dc51f4760aa3729722ed46f45";
}
