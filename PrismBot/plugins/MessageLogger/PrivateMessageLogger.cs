using PrismBot.SDK.Interfaces;
using Sora.EventArgs.SoraEvent;
using YukariToolBox.LightLog;

namespace PrismBot.plugins.MessageLogger;

public class PrivateMessageLogger: IPrivateCommand
{
    public bool Match(string type, BaseMessageEventArgs eventArgs)
    {
        return true;
    }

    public string GetPermission()
    {
        return String.Empty;
    }

    public async Task OnPermissionDeniedAsync(string type, PrivateMessageEventArgs eventArgs)
    {
        return;
    }

    public async Task OnPermissionGrantedAsync(string type, PrivateMessageEventArgs eventArgs)
    {
        Log.Info("MessageLogger", $"收到来自 {eventArgs.SenderInfo.Nick}({eventArgs.SenderInfo.UserId}) 的私聊消息：{eventArgs.Message.RawText}");
    }
}