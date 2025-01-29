using System.Reflection;
using Telegram.Bot;
using Telegram.Bot.Types;
using Telegram.Bot.Types.Enums;
using Telegram.Bot.Types.ReplyMarkups;

namespace CodyMazeBot.Game {
    [StateHandler(BotState.WaitingForLocation)]
    public class WaitForLocationProcessor : BaseStateProcessor {

        public WaitForLocationProcessor(
            Conversation conversation,
            ITelegramBotClient bot,
            MazeGenerator mazeGenerator,
            ILogger<WaitForLocationProcessor> logger
        ) : base(conversation, bot, mazeGenerator, logger) {

        }

        private async Task SendWelcomeMessage(Update update) {
            string code = Conversation.ActiveEvent?.Code;
            
            switch (code)
            {
                case "neoconnessi":
                    {
                        using var welcomeImageStream = Assembly.GetExecutingAssembly()
                            .GetManifestResourceStream("CodyMazeBot.Resources.welcome-neoconnessi.jpg");

                        await Bot.SendPhoto(Conversation.TelegramId, new InputFileStream(welcomeImageStream));
                    }
                    break;

                case null:
                default:
                    if(string.IsNullOrEmpty(code))
                    {
                        await Bot.SendMessage(Conversation.TelegramId,
                            Strings.WelcomeMessage,
                            parseMode: ParseMode.Html);
                    }
                    else
                    {
                        await Bot.SendMessage(Conversation.TelegramId,
                            string.Format(Strings.WelcomeEventMessage, Conversation.ActiveEvent.Title.Localize()),
                            parseMode: ParseMode.Html);
                    }
                    break;
            }
        }

        public override async Task<bool> Process(Update update) {
            if(!Conversation.IncomingCoordinate.HasValue) {
                // This happens if the user does not scan a QR Code
                return false;
            }

            if (Conversation.CurrentUser.MoveCount == 0) {
                await SendWelcomeMessage(update);

                // Block if not on border
                if (!Conversation.IncomingCoordinate.Value.IsOnGridBorder()) {
                    await Bot.SendMessage(Conversation.TelegramId,
                        Strings.WaitForLocationFirstCoordinateWrong,
                        parseMode: ParseMode.Html);
                    return true;
                }

                // Tell user to look in right direction, if not already
                var requiredDirection = Conversation.IncomingCoordinate.Value.GetInitialDirection();
                if (Conversation.IncomingCoordinate.Value.Direction != requiredDirection) {
                    await Bot.SendMessage(Conversation.TelegramId,
                        string.Format(Strings.WaitForLocationFirstSendDirection, GetFacingString(requiredDirection)),
                        parseMode: ParseMode.Html
                    );
                }
            }

            if (Conversation.IncomingCoordinate.Value.Direction.HasValue) {
                // Arrived on new coordinate in one shot
                await HandleArrivalOn(update, Conversation.IncomingCoordinate.Value);

                return true;
            }
            else {
                // Must ask for direction
                await Conversation.AcceptPartialCoordinate(Conversation.IncomingCoordinate.Value);

                await Bot.SendMessage(Conversation.TelegramId,
                    string.Format(Strings.AcceptCoordinateWaitForDirection),
                    parseMode: ParseMode.Html,
                    replyMarkup: new InlineKeyboardMarkup(
                        new InlineKeyboardButton[][] {
                                [
                                    new InlineKeyboardButton(Strings.DirectionNorth) { CallbackData = "N" },
                                ],
                                [
                                    new InlineKeyboardButton(Strings.DirectionWest) { CallbackData = "W" },
                                    new InlineKeyboardButton(Strings.DirectionEast) { CallbackData = "E" },
                                ],
                                [
                                    new InlineKeyboardButton(Strings.DirectionSouth) { CallbackData = "S" },
                                ]
                        }
                    )
                );

                return true;
            }
        }

    }
}
