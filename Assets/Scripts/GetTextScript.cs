using UnityEngine;
using UnityEngine.UI;

public class GetTextScript : MonoBehaviour
{
    string textName;
    string textAge;
    int dzGads;

    public InputField inputNameField;
    public InputField inputAgeField;
    public Text textField;

    public void showText()
    {
        textName = inputNameField.text;
        textAge = inputAgeField.text;

        if (int.TryParse(textAge, out int birthYear))
        {
            if (birthYear > 0 && birthYear <= 2025)
            {
                dzGads = 2025 - birthYear;
                textField.text = "Player " + textName.ToUpper() + " is " + dzGads + " years old!";
            }
            else
            {
                textField.text = "Please enter a valid birth year (1–2025).";
            }
        }
        else
        {
            textField.text = "Please enter a valid number for the birth year.";
        }
    }
}
