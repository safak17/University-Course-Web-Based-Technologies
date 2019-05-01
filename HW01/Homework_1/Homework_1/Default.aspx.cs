using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace Homework_1
{
    public enum CardType
    {
        Unknown = 0,
        MasterCard,
        VISA
    }


    public partial class _Default : Page
    {
        
        const int MAX_LENGTH_MASTER_CARD = 16;
        const string REGEX_MASTER_CARD = "^(51|52|53|54|55)[0-9]*$";    //  Starts with one of (51|52|53|54|55) and contains only numbers.

        const int MAX_LENGTH_VISA = 13;
        const string REGEX_VISA = "^(4)[0-9]*$";                        //  Starts with (4) and contains only numbers.

        Dictionary<int, string> messages = new Dictionary<int, string>()
        {
            { 0, "Card is VALID" },
            { 1, "Unknown card type"},
            { 2, "No card number provided"},
            { 3, "Credit card number is in invalid format"},
            { 4, "Credit card number is invalid"},
            { 5, "Credit card number has an inappropriate number of digits"}
        };


        protected void btnCheck_Click(object sender, EventArgs e)
        {
            string cardNumber = tbCardNumber.Text.Replace(" ", "");     //  Remove the whitespaces.
            displayMessage(checkCreditCard(cardNumber));
        }

        public void displayMessage(int messageCode)
        {
            string message = messages[messageCode];
            ScriptManager.RegisterClientScriptBlock(this,
                this.GetType(),
                "Card Validation",
                "alert('" + message + "')",
                true);
        }


        public int checkCreditCard(string cardNumber)
        {
            CardType selectedCardType = (CardType) ddlCardNames.SelectedIndex;

            if (selectedCardType == CardType.Unknown)
                return 1;   //  "Unknown card type"

            if (String.IsNullOrEmpty(cardNumber))
                return 2;   //  "No card number provided"

            if (!isAppropriate(cardNumber, selectedCardType))
                return 5;   //  "Credit card number has an inappropriate number of digits"

            if (!isValidFormat(cardNumber, selectedCardType))
                return 3;   //  "Credit card number is in invalid format"


            return 0;       //  "Card is VALID"
        }
        

        public bool isValidFormat(string cardNumber, CardType type)
        {
            if ( type == CardType.MasterCard && Regex.IsMatch(cardNumber, REGEX_MASTER_CARD))
                return true;
            
            if ( type == CardType.VISA && Regex.IsMatch(cardNumber, REGEX_VISA))
                return true;

            return false;
        }

        public bool isAppropriate(string cardNumber, CardType type)
        {
            if (type == CardType.MasterCard &&
                cardNumber.Length == MAX_LENGTH_MASTER_CARD)
                return true;

            if (type == CardType.VISA &&
                cardNumber.Length == MAX_LENGTH_VISA)
                return true;

            return false;
        }
        

        //  https://docs.microsoft.com/en-us/dotnet/api/system.web.ui.webcontrols.textbox.textchanged?view=netframework-4.7.2
        //  Occurs when the content of the text box changes between posts to the server.
        protected void tbCardNumber_TextChanged(object sender, EventArgs e)
        {
            string cardNumber = tbCardNumber.Text.Replace(" ", "");  //  Remove the whitespaces.

            if (cardNumber.Length % 4 == 0)                          //  Auto format
                tbCardNumber.Text += " ";
        }
    }
}