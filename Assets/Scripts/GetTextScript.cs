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
            dzGads = 2025 - birthYear;
            textField.text = "Player " + textName.ToUpper() + " is " + dzGads + " years old!";
        }
        else
        {
            textField.text = "Please enter a valid number for age.";
        }
    }
}
