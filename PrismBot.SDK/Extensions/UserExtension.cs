using PrismBot.SDK.Data;
using Sora.Entities;

namespace PrismBot.SDK.Extensions;

public static class UserExtension
{
    /// <summary>
    /// 判断用户是否为游客（未注册玩家）
    /// </summary>
    /// <param name="user"></param>
    /// <returns></returns>
    public static async Task<bool> IsGuestAsync(this User user)
    {
        var botDbContext = new BotDbContext();
        var player = await botDbContext.Players.FindAsync(user.Id);
        if (player == null)
        {
            return true;
        }

        return false;
    }
}