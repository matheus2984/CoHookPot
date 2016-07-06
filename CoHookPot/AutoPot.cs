using System;
using System.Threading;
using CoHookPot.Enum;
using CoHookPot.Hook;

namespace CoHookPot
{
    class AutoPot
    {
        public void AutoPotThread()
        {
            var trh = new Thread(() =>
            {
                while (true)
                {
                    if (!Client.FocusCheck()) continue;

                    KeyboardHook.SendKey(VKCode.SPACE, VKState.Pressed);
                    KeyboardHook.SendKey(VKCode.F1, VKState.Pressed);
                    KeyboardHook.SendKey(VKCode.SPACE, VKState.Pressed);

                    Thread.Sleep(1);
                }
            });
            trh.IsBackground = true;
            trh.Start();
        }
    }
}
