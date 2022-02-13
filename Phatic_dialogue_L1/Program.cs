using Phatic_dialogue_L1.Source;
using Telegram.Bot;

dotenv.net.DotEnv.Load();
string TELEGRAM_BOT_TOKEN = Environment.GetEnvironmentVariable("TELEGRAM_BOT_TOKEN") ?? throw new NullReferenceException("TELEGRAM_BOT_TOKEN");

new TelegramBotClient(TELEGRAM_BOT_TOKEN).StartReceiving(new Telegram.Bot.Extensions.Polling.DefaultUpdateHandler(HandleUpdateAsync, HandleErrorAsync));
async Task HandleErrorAsync(ITelegramBotClient bc, Exception err, CancellationToken ct) => Console.WriteLine(err.Message);
async Task HandleUpdateAsync(ITelegramBotClient botClient, Telegram.Bot.Types.Update update, CancellationToken ct)
{
    if (update.Type != Telegram.Bot.Types.Enums.UpdateType.Message && update?.Message?.Text is null) return;
    await botClient.SendTextMessageAsync(update.Message.Chat.Id, text: Brain.GetAnswer(update.Message.Text), cancellationToken: ct);
}
Console.ReadKey();