# Hazel Roman - Part 1 POE  
**Module:** Programming 2A (PROG6221/w)  
**Student Name:** Hazel Roman  
**Student Number:** ST10438046  

## Project Overview
This project is a **C# Console Application** for **Part 1** of the Cybersecurity Awareness Chatbot POE.  
It follows the brief by including:

- A **voice greeting** in WAV format
- An **ASCII art logo**
- A **personalised greeting**
- A **basic cybersecurity response system**
- **Input validation**
- An **enhanced console UI** with colours, borders, and a typing effect
- **Methods and classes** for clean code structure

The visual style is **Hello Kitty inspired**, while the chatbot content remains focused on **cybersecurity awareness**.

---

## Features Included
- WAV greeting playback on launch
- Custom ASCII art title screen
- User name capture and personalised responses
- Cybersecurity topics:
  - Password safety
  - Phishing
  - Scams
  - Privacy
  - Safe browsing
  - Social engineering
  - Two-factor authentication
- Friendly fallback response for unsupported queries
- Structured code using classes and methods
- GitHub Actions CI workflow

---

## Folder Structure
```text
HelloKittyCyberBot/
│
├── HazelRomanCyberBot.sln
├── README.md
├── .github/
│   └── workflows/
│       └── dotnet.yml
├── docs/
│   └── github-actions-screenshot-placeholder.txt
└── HazelRomanCyberBot/
    ├── HazelRomanCyberBot.csproj
    ├── Program.cs
    ├── Assets/
    │   └── greeting.wav
    ├── Models/
    │   ├── ChatReply.cs
    │   └── UserProfile.cs
    └── Services/
        ├── AsciiArtService.cs
        ├── AudioPlayer.cs
        ├── ConsoleUi.cs
        ├── ResponseEngine.cs
        └── TypingEffect.cs
```

---

## How to Open in Visual Studio
1. Open **Visual Studio**.
2. Select **Open a project or solution**.
3. Open `HazelRomanCyberBot.sln`.
4. Build the solution.
5. Run the project.

---

## Important Notes
- This project is built for **Visual Studio on Windows**.
- The audio file is stored in `Assets/greeting.wav`.
- If you want to improve your marks further, replace the included WAV file with **your own recorded greeting** using the exact assignment wording style.
- The chatbot is designed for **Part 1** only, so it stays as a **console application**.

---

## Suggested Voice Greeting Script
> "Hello! Welcome to the Cybersecurity Awareness Bot. I'm here to help you stay safe online."

You can record this in your own voice and overwrite the existing WAV file.

---

## Suggested GitHub Commit Messages
1. Initial commit: Set up solution structure and project files  
2. Added voice greeting and ASCII logo  
3. Added personalised greeting and user input handling  
4. Implemented cybersecurity responses and topic matching  
5. Improved console styling, validation, and typing effect  
6. Added README and GitHub Actions CI workflow  

---

## GitHub Actions Screenshot
After you push the project to GitHub and the workflow passes, add a screenshot of the **green check mark** here.

See: `docs/github-actions-screenshot-placeholder.txt`

---

## Presentation Tips for Best Marks
In your video, explain:
- Why this is a console app for Part 1
- How the WAV file is played
- How ASCII art is displayed
- How the chatbot reads and validates user input
- How topic matching works
- How classes and methods improve code structure
- How GitHub Actions checks the build

---
## Example Questions to Ask the Bot
- How are you?
- What is your purpose?
- What can I ask you about?
- Tell me about password safety
- Give me a phishing tip
- How do I browse safely?
- What is social engineering?
- Tell me about 2FA
- exit

---
## CI Workflow

The repository includes a GitHub Actions workflow file that restores and builds the project on every push.

-Added ASCII art and console styling
-Implemented voice greeting using WAV file
-Added personalised greeting and name input
-Implemented cybersecurity responses
-Added input validation and fallback response
-Refactored code into classes and methods
-Added README setup instructions
-Added GitHub Actions workflow

##  Part 2 Features

-implemented sentiment detection and memory recall
- Added WPF GUI
- Added Structured response
- Added advanced keyword recognition and conversation flow
