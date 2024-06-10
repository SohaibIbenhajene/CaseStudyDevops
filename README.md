# DevOps & Security Case Study: Maze Game

Welcome to the Maze Game, a Windows Forms application with a SQLite database designed as part of a DevOps & Security case study.

## Project Overview

For this case study, I had the option to choose between three different projects: a Windows Forms/WPF App, a Webscraper, or an ASP.NET web app. I decided to create a Windows Forms application and developed a Maze Game.

The Maze Game is a small 2D game where players navigate a challenging maze using their cursor. The game tracks the player's time, and with a limited number of lives, the objective is to complete the maze as quickly as possible to earn a high score on the leaderboard.

You can play the game [here](https://github.com/SohaibIbenhajene/CaseStudyDevops/actions/runs/9456433929/artifacts/1587429423).

## Game Rules

The Maze Game is straightforward and engaging:

1. **Select Difficulty & Enter Username**: 
   - Choose your preferred difficulty level.
   - Enter your username.

2. **Gameplay**:
   - Click 'Play' to start the game.
   - Navigate through the maze without touching the walls.
   - If you touch a wall, you'll be sent back to the beginning and lose a life.
   - The number of lives varies based on the selected difficulty.

3. **Scoring**:
   - Complete the maze as quickly as possible.
   - Your time and score will be recorded.
   - View your score along with the high scores of other players on the leaderboard.

## Features

- **Multiple Difficulty Levels**: Choose from various difficulty settings to match your skill level.
- **Leaderboard**: Compete with other players and see your rank on the high scores list.
- **Simple and Intuitive Interface**: Easy-to-use controls and a clean user interface make the game accessible to everyone.

## Installation

To run the Maze Game on your local machine:

1. Clone this repository:
   ```sh
   git clone https://github.com/SohaibIbenhajene/CaseStudyDevops.git
   ```
2. Open the project in your preferred IDE.

3. Build and run the application.

## Technologies Used

- **C#**: The primary programming language used for development.
- **Windows Forms**: For creating the user interface.
- **SQLite**: To handle the database operations.
