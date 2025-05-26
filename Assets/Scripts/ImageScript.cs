using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject MaleNord;
    public GameObject FemaleNord;
    public Sprite[] spriteArray;

    public Text descriptionText;
    public Dropdown characterDropdown; 

    private string maleDescription = "The Male Nord hails from the frozen highlands, a land shaped by centuries of harsh winters and relentless battles. Trained from youth to endure pain and wield steel, he embodies the raw strength and endurance of his people. With an unwavering sense of honor and a heart forged in tradition, he stands as both a protector of the old ways and a fearsome warrior against any who threaten his homeland. Clad in heavy furs and iron armor, the Male Nord charges into battle with brute force, his axe cleaving through enemies like winter storms across the mountain pass.";
    private string femaleDescription = "The Female Nord is a fierce and agile warrior, born in the snow-covered reaches where survival sharpens both body and mind. With eyes like frost and a spirit forged in fire, she balances ferocity with intuition. She may not match the brute strength of her male counterpart, but her speed, precision, and resilience make her an equally deadly opponent. Raised on legends of shieldmaidens and ancestral magic, she channels both combat skill and ancient knowledge to protect her kin. Whether leading a charge or navigating shadowy forests, the Female Nord is a force of nature—undaunted, untamed, and unbreakable.";

    void Start()
    {
        Dropwdown(characterDropdown.value); 
    }

    public void Dropwdown(int index)
    {
        if (index == 0)
        {
            MaleNord.SetActive(true);
            FemaleNord.SetActive(false);
            descriptionText.text = maleDescription;
        }
        else if (index == 1)
        {
            FemaleNord.SetActive(true);
            MaleNord.SetActive(false);
            descriptionText.text = femaleDescription;
        }
    }
}
