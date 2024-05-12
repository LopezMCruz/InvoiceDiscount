# InvoiceTotal

# Discount Calculator Application

## Introduction
This Discount Calculator is a simple Windows Forms application developed in C# using Visual Studio. It is designed to calculate the discount and total amount based on a given subtotal. This project serves as an introductory exercise to learn C# and familiarize with the Visual Studio IDE.

## Functionality
The application calculates the discount percentage based on the following criteria:
- If the subtotal is $500 or more, the discount is 20%.
- If the subtotal is between $350 and $499.99, the discount is 15%.
- If the subtotal is between $200 and $349.99, the discount is 10%.
- Subtotals less than $200 receive no discount.

The calculated discount amount and the total after applying the discount are displayed to the user.

## Build and Run
To build and run this application, you will need:

- Visual Studio 2019 or later
- .NET Framework 4.7.2 or higher

### Steps to Build and Run:
1. **Clone or download the repository:**
   ```bash
   git clone https://github.com/LopezMCruz/InvoiceDiscount
   cd InvoiceDiscount
   ```
2. **Open the solution in Visual Studio:**
	- Double-click on the solution file (*.sln) to open it in Visual Studio.
3. **Restore NuGet packages:**

    - Right-click on the solution in the Solution Explorer and select "Restore NuGet Packages".

4. **Build the solution:**

    - Press Ctrl+Shift+B to build the solution or go to Build -> Build Solution in the menu.

5. **Run the application:**

    - Press F5 to run the application with debugging enabled, or Ctrl+F5 to run it without debugging.
