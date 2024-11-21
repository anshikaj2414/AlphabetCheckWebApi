#Key Files:
AlphabetCheckController.cs: Contains the logic to check if the input string contains all letters of the alphabet.
AlphabetCheckControllerTests.cs: Unit tests for the AlphabetCheckController to validate the functionality.

#API Endpoint
GET /api/alphabetcheck/{inputString}
Description: This API endpoint receives a string (inputString) and checks if the string contains all letters of the English alphabet (case-insensitive).
Request Parameter: inputString (string) - The string to check.
Response: Returns true if all letters of the alphabet are present in the string, otherwise false.

#Example Request:

GET /api/alphabetcheck/The quick brown fox jumps over the lazy dog
Example Response:
true

Example of a Bad Request:
If the input string is empty or null, the API will return a 400 Bad Request response:

{
    "error": "Input string cannot be null or empty."
}

#Prerequisites
To run this project locally, ensure you have the following installed:

.NET SDK 6.0 or higher
Visual Studio or Visual Studio Code (for development)
Steps to Run Locally      
1. Clone the repository
     - git clone https://github.com/yourusername/AlphabetCheckWebApp.git
     - cd AlphabetCheckWebApp
2. Restore the dependencies
Run the following command to restore the NuGet dependencies:

     - dotnet restore
3. Build the application
Build the application to ensure there are no errors:

     - dotnet build
4. Run the Web API
Start the application by running:

      - dotnet run
      You can access the endpoint by navigating to:
      - http://localhost:5000/api/alphabetcheck/{inputString}
5. Run the Tests
To run the unit tests and ensure everything works as expected, run the following command:

      - dotnet test
This will execute all tests defined in the AlphabetCheckControllerTests.cs file.

Running Tests with xUnit
The unit tests are written using the xUnit testing framework. The test file AlphabetCheckControllerTests.cs contains tests for different cases, including:

A string that contains all the letters of the alphabet.
A string that is missing some letters.
A string with just the alphabet in order.
A string with no alphabetic characters at all.
To run the tests, simply use the following command:

    - dotnet test
This will execute all the tests defined in the project.

#Sample Test Cases:

[Theory]
[InlineData("The quick brown fox jumps over the lazy dog", true)]  // Contains all letters
[InlineData("Hello World", false)]  // Missing letters
[InlineData("abcdefghijklmnopqrstuvwxyz", true)]  // Exactly all letters
[InlineData("1234567890!@#$%^", false)]  // No letters at all
These tests verify that the API correctly identifies whether a string contains all letters of the alphabet.

#Technologies Used      
1.  .NET Core 8.0: Framework for building the Web API.2.  xUnit: Testing framework used for unit tests.
3.  C#: Programming language used for the Web API and tests.
