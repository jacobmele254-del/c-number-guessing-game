# c-number-guessing-game
🎮 Number Guessing Game
A simple engaging console-based game designed to help beginners learn the fundamentals of C# programming. Challenge yourself to guess the computer's secret number within a limited number of attempts!

📋 Table of Contents
About the Project
Key Features
Technologies Used
System Requirements
Installation
How to Run
How to Play
Configuration Options
Project Structure
Troubleshooting
Learning Objectives
Contributing
License
📖 About the Project
The Number Guessing Game is an interactive console application where the computer randomly selects a secret number within a specified range, and the player attempts to guess it correctly. With each guess, the game provides feedback (too high or too low) to guide the player toward the correct answer.

This project is perfect for:

Beginners learning C# programming fundamentals
Students practicing control flow, loops, and conditionals
Developers looking for a quick C# refresher project
Through this game, you'll understand essential C# concepts including:

Variables and data types
Loops (while, for)
Conditional statements (if, else if, else)
User input handling
Random number generation
Game logic and control flow
✨ Key Features
🎲 Random Number Generation
Computer generates a random secret number within configurable ranges
Uses C#'s Random class for unpredictable gameplay
🎯 Difficulty Levels
Easy Mode: 1-50 range, 10 attempts
Medium Mode: 1-100 range, 7 attempts
Hard Mode: 1-200 range, 5 attempts
💬 User Guess Input
Interactive console-based input
Input validation to prevent crashes
Clear prompts and user-friendly interface
📊 Feedback System
Real-time feedback: "Too high!" or "Too low!"
Attempt counter to track progress
Proximity hints for close guesses
🏆 Score Tracking
Tracks number of attempts per round
Records best score (fewest attempts)
🔄 Replay Option
Play multiple rounds without restarting
Cumulative score tracking across sessions
Graceful exit option
🛠️ Technologies Used
Technology	Purpose
C#	Primary programming language
.NET SDK	Runtime framework and development kit
Visual Studio Code	Recommended code editor (or Visual Studio 2022)
Console Application	Interactive terminal-based interface
💻 System Requirements
For Windows
OS: Windows 10 or later (64-bit)
RAM: Minimum 4 GB (8 GB recommended)
Disk Space: At least 1–2 GB free for SDK and dependencies
Additional: Windows Terminal or Command Prompt
For macOS
OS: macOS 10.15 (Catalina) or later
RAM: Minimum 4 GB (8 GB recommended)
Disk Space: At least 1–2 GB free
Additional: Terminal access
For Linux
OS: Supported distributions (Ubuntu 20.04+, Fedora, Debian, etc.)
RAM: Minimum 4 GB (8 GB recommended)
Disk Space: At least 1–2 GB free
Additional: Bash or terminal access for dotnet commands
📥 Installation
Step 1: Install .NET SDK
Windows
Visit https://dotnet.microsoft.com/download
Download the latest .NET SDK installer
Run the installer and follow the prompts
Verify installation:
dotnet --version
macOS
Download .NET SDK from https://dotnet.microsoft.com/download
Open the .pkg file and follow installation steps
Verify installation:
dotnet --version
Linux (Ubuntu/Debian)
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0
dotnet --version
Step 2: Install Visual Studio Code (Optional but Recommended)
Download from https://code.visualstudio.com/
Install the C# Dev Kit extension from the Extensions marketplace
Step 3: Clone or Download the Project
Option A: Clone via Git
git clone https://github.com/yourusername/number-guessing-game.git
cd number-guessing-game
Option B: Download ZIP
Download the project as a ZIP file
Extract to your desired location
Navigate to the project folder in terminal
🚀 How to Run
Using Command Line / Terminal
Navigate to the project directory:

cd path/to/NumberGuessingGame
Run the application:

dotnet run
Using Visual Studio Code
Open the project folder in VS Code
Press F5 or click Run → Start Debugging
The game will launch in the integrated terminal
Using Visual Studio 2022
Open the .sln solution file
Press F5 or click the Start button
The console window will appear
🎮 How to Play
Game Flow
Launch the Game

=== NUMBER GUESSING GAME ===
Welcome! Can you guess my secret number?
Choose Difficulty

Select difficulty:
1. Easy (1-50, 10 attempts)
2. Medium (1-100, 7 attempts)
3. Hard (1-200, 5 attempts)

Your choice: 2
Make Your Guesses

I'm thinking of a number between 1 and 100
You have 7 attempts remaining.

Attempt 1/7 - Your guess: 50
📈 Too low! Try higher.

Attempt 2/7 - Your guess: 75
📉 Too high! Try lower.

Attempt 3/7 - Your guess: 62
🎉 Correct! You won in 3 attempts!
Play Again?

Play again? (y/n): y
Tips for Players
Start with the middle of the range (e.g., 50 for 1-100)
Use binary search strategy: eliminate half the possibilities each guess
Pay attention to feedback to narrow down the range
Track your best score and try to beat it!
📁 Project Structure
NumberGuessingGame/
│
├── Program.cs                 # Main game logic
├── NumberGuessingGame.csproj  # Project configuration file
├── README.md                  # This file
├── LICENSE                    # MIT License
│
├── bin/                       # Compiled binaries (generated)
│   └── Debug/
│       └── net8.0/
│
└── obj/                       # Build artifacts (generated)
    └── ...
Key Files Explained
File	Purpose
Program.cs	Contains the main game logic, including loops, conditionals, and user input handling
NumberGuessingGame.csproj	Project metadata and dependencies configuration
README.md	Documentation (this file)
LICENSE	MIT License for open-source distribution
🔧 Troubleshooting
Issue: "dotnet: command not found"
Solution:

Ensure .NET SDK is installed: dotnet --version
On Windows: Add .NET to PATH environment variable
On macOS/Linux: Restart terminal or run source ~/.bashrc
Issue: "Build failed" or compilation errors
Solution:

# Clean and rebuild
dotnet clean
dotnet build
Issue: Program crashes on invalid input
Solution:

The game includes input validation with int.TryParse()
If crashes persist, ensure you're using the latest version with error handling:
if (!int.TryParse(Console.ReadLine(), out int guess))
{
    Console.WriteLine("Invalid input! Please enter a number.");
    continue;
}
Issue: Random numbers seem predictable
Solution:

Ensure Random random = new Random(); is created once outside loops
Do NOT create new Random() instances inside loops
Issue: Console window closes immediately
Solution (Windows):

// Add at the end of Main()
Console.WriteLine("\nPress any key to exit...");
Console.ReadKey();
Issue: Can't see colored text in terminal
Solution:

Use Windows Terminal (not Command Prompt)
On VS Code, ensure terminal supports ANSI colors
Test with: Console.ForegroundColor = ConsoleColor.Green;
License
This project is for educational purposes. Feel free to use and modify!

Happy Coding! 🚀