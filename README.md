# Bicycle Mushroom App

A Windows Forms application built with .NET 10. The application provides a login screen followed by two small programs:

- Bicycle rental cost calculator
- Mushroom identifier using a question-and-answer flow

## Requirements

- Windows
- .NET 10 SDK
- Visual Studio with .NET desktop development tools

## Login

The default login credentials are:

- Username: `ngenzi`
- Password: `123`

To change them, edit the `ValidUsername` and `ValidPassword` constants in `LoginForm.cs`.

## Features

### Login

- Validates the username and password.
- Displays an error for invalid credentials.
- Clears the password field after a failed login.

### Bicycle Rental Calculator

- Accepts a starting hour from 0 to 23.
- Accepts an ending hour from 1 to 24.
- Validates numeric input and the time range.
- Calculates the total rental cost using time-based rates.
- Displays the total in RWF.

### Mushroom Identifier

- Uses a series of yes-or-no questions.
- Identifies a mushroom based on the selected answers.
- Allows the questionnaire to be restarted.
- Allows the user to log out and return to the login screen.

## Running the Application

1. Open `BicycleMushroomApp.slnx` in Visual Studio.
2. Restore the project if Visual Studio requests it.
3. Build the solution.
4. Start the application with `F5` or `Ctrl+F5`.
5. Sign in using the default credentials.

Alternatively, run the project from PowerShell:

```powershell
dotnet run --project BicycleMushroomApp.csproj
```

## Project Structure

- `Program.cs` - Application entry point.
- `LoginForm.cs` - Login logic.
- `ChooseForm.cs` - Program selection screen.
- `BicycleForm.cs` - Bicycle rental calculator.
- `MushroomForm.cs` - Mushroom identification questionnaire.
- `*.Designer.cs` - Windows Forms designer-generated user interface code.
- `*.resx` - Windows Forms resources.
- `BicycleMushroomApp.csproj` - Project configuration.

## Target Framework

The project targets `net10.0-windows` and uses Windows Forms.

## Editing the Design

You can change the look of any screen without writing code:

1. In Solution Explorer, double-click `LoginForm.cs`, `ChooseForm.cs`, `BicycleForm.cs` or `MushroomForm.cs`. The visual designer opens.
2. Click a control, then change its text, colors, font, size and position in the Properties window (`F4`).
3. Drag controls to move or resize them. Drag new ones from the Toolbox (`Ctrl+Alt+X`).
4. To connect a button to code, double-click it. Do not edit the `*.Designer.cs` files by hand.
