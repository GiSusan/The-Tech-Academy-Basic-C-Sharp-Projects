# Collection of assignments and projects from my C# course

## Math and Comparison Operators (Assignment) | Anonymous Income Comparison Program

The "Anonymous Income Comparison Program" is a console application written in C# that allows you to compare the annual salaries of two individuals based on their hourly rates and hours worked per week.

### Usage

1. Run the program.
2. Follow the prompts to enter the hourly rate and hours worked per week for Person 1 and Person 2.
3. The program will calculate the annual salaries for both individuals using the provided input.
4. The annual salaries of Person 1 and Person 2 will be displayed on the console.
5. The program will determine if Person 1 makes more money than Person 2 and display the result.

### Input Validation

The program includes input validation to ensure that the user enters valid numeric values for the hourly rates and hours worked per week. If invalid input is detected, appropriate error messages will be displayed, and the program will exit.

### Decimal Precision

To provide more accurate calculations, the program uses the `decimal` data type for storing hourly rates, ensuring decimal precision in the salary calculations.

### Important Note

Please note that this code assumes that the user will enter valid numeric input for the hourly rates and hours worked per week. If the input does not adhere to this expectation, the program will display error messages and exit. Additional validation or error handling can be added as per specific requirements.



## Console Application - Number Operations

This console application performs various mathematical operations on user inputs and displays the results.

### Operations

1. Multiply by 50: Takes an input from the user, multiplies it by 50, and prints the result to the console.

2. Add 25: Takes an input from the user, adds 25 to it, and prints the result to the console.

3. Divide by 12.5: Takes an input from the user, divides it by 12.5, and prints the result to the console.

4. Greater than 50: Takes an input from the user, checks if it is greater than 50, and prints the true/false result to the console.

5. Calculate Remainder: Takes an input from the user, divides it by 7, and prints the remainder to the console.

### Usage

1. Enter a number: The user should enter a number as an input.

2. The application will perform the specified operation based on the chosen option.

3. The result will be displayed on the console.

### Prerequisites

- .NET Framework installed on the system.

### How to Run

1. Clone the repository or download the source code.

2. Open the terminal or command prompt and navigate to the project directory.

3. Compile the application using the following command:

4. Run the application using the following command:

5. Follow the instructions on the console to input a number and view the results.

### Note

- The application can handle inputs larger than 10,000,000.

- Ensure that the input is a valid number to avoid errors.

- Please refer to the code comments for detailed explanations of each step.

## Boolean Logic Assignment | Car Insurance Approval Program

This is a simple console application that determines whether an applicant qualifies for car insurance based on age, DUI history, and the number of speeding tickets.

### Requirements

- Applicants must be over 15 years old.
- Applicants must not have any DUI's.
- Applicants must not have more than 3 speeding tickets.

### Usage

1. Run the program.
2. Enter the applicant's age when prompted.
3. Enter 'true' or 'false' to indicate if the applicant has ever had a DUI.
4. Enter the number of speeding tickets the applicant has.
5. The program will display whether the applicant is qualified or not.


## Package Express

Welcome to Package Express, a console application for getting a shipping quote for a package.

### Description

The Package Express application allows users to calculate the shipping quote for a package based on its weight and dimensions. It prompts the user to enter the package weight, width, height, and length, and performs various checks and calculations to determine if the package qualifies for shipping and to calculate the shipping quote.

The application follows the following steps:

1. Displays a welcome message to the user.

2. Prompts the user to enter the package weight. If the weight is greater than 50, an error message is displayed, and the program terminates.

3. If the weight is within the acceptable range, the user is prompted to enter the package width, height, and length. If the total dimensions exceed 50, an error message is displayed, and the program terminates.

4. If the dimensions are within the acceptable range, the program calculates the shipping quote by multiplying the total dimensions by the weight and dividing the result by 100.

5. The calculated shipping quote is then displayed to the user as a dollar amount, rounded to two decimal places.

6. Finally, a thank you message is displayed, and the program ends.

### Getting Started

To run the Package Express application, follow these steps:

1. Ensure you have a C# development environment set up (e.g., Visual Studio, Visual Studio Code, or a compatible compiler).

2. Create a new C# project.

3. Copy the provided code into the project file.

4. Build and run the application.

5. Follow the on-screen instructions and enter the required information to get the shipping quote.

### Development

The application is written in C# and uses the console for input and output. It employs basic conditional statements and calculations to determine the eligibility for shipping and calculate the quote.

The code includes comments to explain the purpose of each line or block and facilitate understanding for other developers.


## Student Database - Console Application

The Student Database Console Application is a .NET Core application that allows you to add a student to a database using the Entity Framework Code-First approach. It provides a simple command-line interface for entering the student name and storing it in the database.

### Description

The Student Database Console Application enables you to interactively add students to a database by entering their names. It utilizes the Entity Framework Code-First approach, which automatically generates the underlying database schema based on the defined entity classes. The application establishes a connection to the database, adds the student with the entered name, and saves the changes.

### Prerequisites

Before running the application, make sure you have the following:

- .NET Core SDK installed on your machine.
- A compatible database server (such as SQL Server) available for the application to connect to.

### Usage

1. Run the application.

2. When prompted, enter the name of the student you want to add.

3. The application will connect to the database, add the student with the entered name, and save the changes.

4. Upon successful addition, the application will display a message indicating that the student has been added.

5. Press any key to exit the application.



