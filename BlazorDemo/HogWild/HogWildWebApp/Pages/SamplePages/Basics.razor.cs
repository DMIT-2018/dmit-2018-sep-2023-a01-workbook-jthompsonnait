﻿using Microsoft.AspNetCore.Components;

namespace HogWildWebApp.Pages.SamplePages
{
    public partial class Basics
    {
        #region Fields
        #region Method
        //  used to display my name
        private string? myName;
        //  the odd or even value
        private int oddEvenValue;
        #endregion

        #region Text Boxes
        //  email address
        private string emailText;
        //  password
        private string passwordText;
        //  date 
        private DateTime? dateText = DateTime.Today;
        #endregion
        #region Radio Buttons, Checkboxes & Text Area
        //  selected meal
        private string meal = "breakfast";
        private string[] meals { get; set; } = new string[] { "breakfast", "lunch", "dinner", "snacks" };
        //  used to hold the value of the acceptance
        private bool acceptanceBox;
        // used to hold the value for the message body
        private string messageBody;
        #endregion
        //  used to display any feedback to the end user
        private string feedback;
        #endregion

        //  This method is automatically called when the component is initialized
        protected override async Task OnInitializedAsync()
        {
            //  Call the vase class OnInitializedAsync method (if any)
            await base.OnInitializedAsync();

            //  Call the RandomValue method to perform custom initialization logic
            RandomValue();
        }

        //  Generates a random number between 0 and 25 using the Random class
        //  Checks if the generated number is even
        //  Sets the myName variable to a message if even, or to null if odd
        private void RandomValue()
        {
            //  Create an instance of the Random class to generate random numbers
            Random rnd = new Random();

            //  Generate a random integer between 0 (inclusive) and 25 (exclusive_
            oddEvenValue = rnd.Next(0, 25);

            //  check if the generate number is evern.
            if (oddEvenValue % 2 == 0)
            {
                //  If the number is even, construct a message with the number and assign it to myName
                myName = $"James is even {oddEvenValue}";
            }
            else
            {
                //  If the number is odd, set myName to null
                myName = null;
            }
            //  Trigger an asynchronous update of the components state to reflect the changes made
            InvokeAsync(StateHasChanged);
        }

        //  This method is called when a user submits text input.
        private void TextSubmit()
        {
            // Combine the values of emailText, passwordText, and dateText into a feedback message.
            feedback = $"Email {emailText}; Password {passwordText}; Date {dateText}";

            // Trigger a re-render of the component to reflect the updated feedback.
            InvokeAsync(StateHasChanged);
        }

        // Handle the selection of the loop meal
        private void HandleMealSelection(ChangeEventArgs e)
        {
            meal = e.Value.ToString();
        }
    }

}