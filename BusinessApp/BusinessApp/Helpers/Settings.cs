// Helpers/Settings.cs
using Plugin.Settings;
using Plugin.Settings.Abstractions;

namespace BusinessApp.Helpers
{
  /// <summary>
  /// This is the Settings static class that can be used in your Core solution or in any
  /// of your client applications. All settings are laid out the same exact way with getters
  /// and setters. 
  /// </summary>
  public static class Settings
  {
    private static ISettings AppSettings
    {
      get
      {
        return CrossSettings.Current;
      }
    }

    #region Setting Constants

    private const string SettingsKey = "settings_key";
    private static readonly string SettingsDefault = string.Empty;
        private const string EmailKey ="email_key";
        private static readonly string EmailDefault = string.Empty;
        private const string LoginKey = "login_key";
        private static readonly string LoginDefault = "logged out";
# endregion


        public static string GeneralSettings
        {
          get
          {
            return AppSettings.GetValueOrDefault<string>(SettingsKey, SettingsDefault);
          }
          set
          {
            AppSettings.AddOrUpdateValue<string>(SettingsKey, value);
          }
       }
        public static string GeneralEmail
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(EmailKey, EmailDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(EmailKey, value);
            }
        }
        public static string GeneralLogin
        {
            get
            {
                return AppSettings.GetValueOrDefault<string>(LoginKey, LoginDefault);
            }
            set
            {
                AppSettings.AddOrUpdateValue<string>(LoginKey, value);
            }
        }
    }
}