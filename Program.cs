using HazelRomanCyberBot.Models;
using HazelRomanCyberBot.Services;

namespace HazelRomanCyberBot;

/// <summary>
/// Programming 2A POE - Part 1
/// Student Name: Hazel Roman
/// Student Number: ST10438046
/// Theme: Hello Kitty inspired Cybersecurity Awareness Chatbot
/// This is a console application for Part 1 of the assignment.
/// </summary>
internal static class Program
{
    private static void Main()
    {
        Console.Title = "Hazel Roman - Hello Kitty Cybersecurity Chatbot";

        UserProfile userProfile = new();
        ConsoleUi consoleUi = new();
        AudioPlayer audioPlayer = new();
        AsciiArtService asciiArtService = new();
        ResponseEngine responseEngine = new();

        consoleUi.ConfigureConsole();
        audioPlayer.PlayGreeting();
        consoleUi.ShowSplashScreen(asciiArtService.GetLogo());

        userProfile.Name = consoleUi.PromptForName();

        consoleUi.ShowBotMessage($"Welcome, {userProfile.Name}! I'm KittyGuard, your classy cybersecurity helper.");
        consoleUi.ShowBotMessage("Ask me about passwords, phishing, scams, privacy, safe browsing, social engineering, or two-factor authentication.");
        consoleUi.ShowHelpHint();

        bool keepRunning = true;

        while (keepRunning)
        {
            string userInput = consoleUi.PromptForInput();

            if (string.IsNullOrWhiteSpace(userInput))
            {
                consoleUi.ShowWarning("Please type something so I can help you.");
                continue;
            }

            try
            {
                ChatReply reply = responseEngine.GenerateReply(userInput, userProfile);

                if (reply.ShouldExit)
                {
                    consoleUi.ShowBotMessage(reply.Message);
                    keepRunning = false;
                    continue;
                }

                if (reply.HighlightedTopic is not null)
                {
                    consoleUi.ShowSectionHeader($"TOPIC: {reply.HighlightedTopic}");
                }

                consoleUi.ShowBotMessage(reply.Message);
            }
            catch (Exception ex)
            {
                consoleUi.ShowError($"Something unexpected happened: {ex.Message}");
                consoleUi.ShowBotMessage("Let's keep going. Please try your question again.");
            }
        }

        consoleUi.ShowDivider();
        consoleUi.ShowBotMessage($"Stay safe online, {userProfile.Name}. Goodbye!");
        consoleUi.ResetConsole();
    }
}