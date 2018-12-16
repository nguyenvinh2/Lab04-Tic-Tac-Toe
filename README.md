# Tic-Tac-Toe

## Tic Tac Toe Game

This is a basic C# Console Application that utilizes external classes generate a Tic Tac Toe game for two players. It asks for each user to input a coordinate selection to make a mark on a 3X3 grid, alternating the turns between each player. Get 3 markers on a straight line to win.

## Version

V1.0 - 10/13/2018 Basic Functionality w/ Testing Unit

## Requirements

Visual Studios 2017 or equivalent C# IDE

.NET Core 2.1 SDK

## Instructions

Clone this repo to local storage and open it up using Visual Studios 2017.

Open the Lab04_TicTacToe.sln solution located in the Lab04_TicTacToe folder.

Compile the Program.cs and run the application.

A console command should appear to prompt you for inputs. 

Select options as they appear.

## Additional Notes

Each position on the 3X3 grid has a ID number associated with it. Input that number to enter the coordinate.

There is no option to play again once the game is over.

## Testing

XUnit is included and tests the following:

1. Whether the game can detect winning conditions

2. Whether the game knows whose turn it is

3. Whether the game can switch player turns

4. Where the game can return the right coordinate based on user input.

## Result

![Console](Capture.PNG?raw=true "Output")
