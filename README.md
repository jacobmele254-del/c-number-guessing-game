# 🎮 Number Guessing Game

[![C#](https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white)](https://docs.microsoft.com/en-us/dotnet/csharp/)
[![.NET](https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white)](https://dotnet.microsoft.com/)
[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=for-the-badge)](https://opensource.org/licenses/MIT)

A simple yet engaging console-based game designed to help beginners learn the fundamentals of C# programming. Challenge yourself to guess the computer's secret number within a limited number of attempts!

---

## 📋 Table of Contents

- [About the Project](#about-the-project)
- [Key Features](#key-features)
- [Technologies Used](#technologies-used)
- [System Requirements](#system-requirements)
- [Installation](#installation)
- [How to Run](#how-to-run)
- [How to Play](#how-to-play)
- [Configuration Options](#configuration-options)
- [Project Structure](#project-structure)
- [Troubleshooting](#troubleshooting)
- [Learning Objectives](#learning-objectives)
- [Contributing](#contributing)
- [License](#license)

---

## 📖 About the Project

The **Number Guessing Game** is an interactive console application where the computer randomly selects a secret number within a specified range, and the player attempts to guess it correctly. With each guess, the game provides feedback (too high or too low) to guide the player toward the correct answer.

This project is perfect for:
- **Beginners** learning C# programming fundamentals
- **Students** practicing control flow, loops, and conditionals
- **Developers** looking for a quick C# refresher project

Through this game, you'll understand essential C# concepts including:
- Variables and data types
- Loops (`while`, `for`)
- Conditional statements (`if`, `else if`, `else`)
- User input handling
- Random number generation
- Game logic and control flow

---

## ✨ Key Features

### 🎲 Random Number Generation
- Computer generates a random secret number within configurable ranges
- Uses C#'s `Random` class for unpredictable gameplay

### 🎯 Difficulty Levels
- **Easy Mode**: 1-50 range, 10 attempts
- **Medium Mode**: 1-100 range, 7 attempts
- **Hard Mode**: 1-200 range, 5 attempts

### 💬 User Guess Input
- Interactive console-based input
- Input validation to prevent crashes
- Clear prompts and user-friendly interface

### 📊 Feedback System
- Real-time feedback: "Too high!" or "Too low!"
- Attempt counter to track progress
- Proximity hints for close guesses (optional)

### 🏆 Score Tracking
- Tracks number of attempts per round
- Records best score (fewest attempts)
- Displays win/loss statistics

### 🔄 Replay Option
- Play multiple rounds without restarting
- Cumulative score tracking across sessions
- Graceful exit option

---

## 🛠️ Technologies Used

| Technology | Purpose |
|------------|---------|
| **C#** | Primary programming language |
| **.NET SDK** | Runtime framework and development kit |
| **Visual Studio Code** | Recommended code editor (or Visual Studio 2022) |
| **Console Application** | Interactive terminal-based interface |

---

## 💻 System Requirements

### For Windows
- **OS**: Windows 10 or later (64-bit)
- **RAM**: Minimum 4 GB (8 GB recommended)
- **Disk Space**: At least 1–2 GB free for SDK and dependencies
- **Additional**: Windows Terminal or Command Prompt

### For macOS
- **OS**: macOS 10.15 (Catalina) or later
- **RAM**: Minimum 4 GB (8 GB recommended)
- **Disk Space**: At least 1–2 GB free
- **Additional**: Terminal access

### For Linux
- **OS**: Supported distributions (Ubuntu 20.04+, Fedora, Debian, etc.)
- **RAM**: Minimum 4 GB (8 GB recommended)
- **Disk Space**: At least 1–2 GB free
- **Additional**: Bash or terminal access for `dotnet` commands

---

## 📥 Installation

### Step 1: Install .NET SDK

#### Windows
1. Visit [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Download the latest .NET SDK installer
3. Run the installer and follow the prompts
4. Verify installation:
   ```bash
   dotnet --version
   ```

#### macOS
1. Download .NET SDK from [https://dotnet.microsoft.com/download](https://dotnet.microsoft.com/download)
2. Open the `.pkg` file and follow installation steps
3. Verify installation:
   ```bash
   dotnet --version
   ```

#### Linux (Ubuntu/Debian)
```bash
wget https://packages.microsoft.com/config/ubuntu/$(lsb_release -rs)/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install -y dotnet-sdk-8.0
dotnet --version
```

### Step 2: Install Visual Studio Code (Optional but Recommended)

1. Download from [https://code.visualstudio.com/](https://code.visualstudio.com/)
2. Install the **C# Dev Kit** extension from the Extensions marketplace

### Step 3: Clone or Download the Project

#### Option A: Clone via Git
```bash
git clone https://github.com/yourusername/number-guessing-game.git
cd number-guessing-game
```

#### Option B: Download ZIP
1. Download the project as a ZIP file
2. Extract to your desired location
3. Navigate to the project folder in terminal

---

## 🚀 How to Run

### Using Command Line / Terminal

1. Navigate to the project directory:
   ```bash
   cd path/to/NumberGuessingGame
   ```

2. Run the application:
   ```bash
   dotnet run
   ```

### Using Visual Studio Code

1. Open the project folder in VS Code
2. Press `F5` or click **Run → Start Debugging**
3. The game will launch in the integrated terminal

### Using Visual Studio 2022

1. Open the `.sln` solution file
2. Press `F5` or click the **Start** button
3. The console window will appear

---

## 🎮 How to Play

### Game Flow

1. **Launch the Game**
   ```
   === NUMBER GUESSING GAME ===
   Welcome! Can you guess my secret number?
   ```

2. **Choose Difficulty**
   ```
   Select difficulty:
   1. Easy (1-50, 10 attempts)
   2. Medium (1-100, 7 attempts)
   3. Hard (1-200, 5 attempts)
   
   Your choice: 2
   ```

3. **Make Your Guesses**
   ```
   I'm thinking of a number between 1 and 100
   You have 7 attempts remaining.
   
   Attempt 1/7 - Your guess: 50
   📈 Too low! Try higher.
   
   Attempt 2/7 - Your guess: 75
   📉 Too high! Try lower.
   
   Attempt 3/7 - Your guess: 62
   🎉 Correct! You won in 3 attempts!
   ```

4. **Play Again?**
   ```
   Play again? (y/n): y
   ```

### Tips for Players
- Start with the middle of the range (e.g., 50 for 1-100)
- Use binary search strategy: eliminate half the possibilities each guess
- Pay attention to feedback to narrow down the range
- Track your best score and try to beat it!


## 📁 Project Structure

```
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
```


## 🔧 Troubleshooting

### Issue: "dotnet: command not found"

**Solution:**
- Ensure .NET SDK is installed: `dotnet --version`
- On Windows: Add .NET to PATH environment variable
- On macOS/Linux: Restart terminal or run `source ~/.bashrc`

### Issue: "Build failed" or compilation errors

**Solution:**
```bash
# Clean and rebuild
dotnet clean
dotnet build
```

### Issue: Program crashes on invalid input

**Solution:**
- The game includes input validation with `int.TryParse()`
- If crashes persist, ensure you're using the latest version with error handling:


   - System information (OS, .NET version)


**Happy Coding! 🚀**
