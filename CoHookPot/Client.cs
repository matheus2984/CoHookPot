using System;
using CoHookPot.Hook;

namespace CoHookPot
{
    public static class Client
    {
        public static bool FocusCheck()
        {
            string title = WindowHook.GetActiveWindowTitle();
            return !string.IsNullOrEmpty(title) && title.Contains("Conquer");
        }
    }
}