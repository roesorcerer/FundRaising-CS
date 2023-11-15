# Fund Raising Sign-Up Program Readme

## Introduction
This README file provides information and instructions for the "Fund Raising Sign-Up Program" code. The program is written in C# and allows volunteers to sign up for various fundraising events, input their information, and view their sign-up details.

## Code Overview
The provided C# code defines a simple console application that collects information from volunteers and stores it in a data structure. Here's a brief overview of the code structure:

1. The code defines an interface `IVariables` with properties `Name`, `Event`, `Hours`, and `Status`.
2. The `Base` class implements the `IVariables` interface, providing properties to store volunteer information.
3. The `Main` method serves as the entry point for the program and handles user interactions.

## Usage Instructions
To run the Fund Raising Sign-Up Program, follow these steps:

1. Ensure you have a C# development environment set up (e.g., Visual Studio or Visual Studio Code).

2. Copy and paste the provided code into a new C# project or file.

3. Build and run the program.

4. Follow the on-screen prompts to input volunteer information:

   - Enter your name.
   - Choose the events you want to sign up for (options 1 to 5).
   - Specify the number of hours you can work per week.
   - Indicate whether you are a new volunteer (Yes/No).

5. After completing the input, the program will display your volunteer information, including your name, selected events, hours per week, and volunteer status.

6. You can repeat the sign-up process for multiple volunteers if needed.

## Program Flow
The program follows these key steps:

1. Welcomes the user and collects their name.

2. Provides a menu for the user to select events to sign up for (options 1 to 5). The selected events are stored in a list.

3. Asks for the number of hours the volunteer can work per week.

4. Determines whether the volunteer is a new or returning volunteer based on their response.

5. Displays the volunteer's information, including name, selected events, hours per week, and volunteer status.

6. The program continues to add volunteers until the user chooses to finish adding volunteer activities (option 6).

## Notes
- The program assumes that the user provides valid input and does not include extensive error handling.
- There is a minor issue with the `if` conditions for determining the volunteer status. Both conditions check for "Yes/yes" as the input, but the second condition is likely intended to check for "No/no."

Feel free to customize and enhance the code as needed for your specific requirements and error handling.
