using UnityEngine;

public class ClothingToggleScript : MonoBehaviour
{
    public GameObject Helmet1;
    public GameObject Helmet2;
    public GameObject Chestplate1;
    public GameObject Chestplate2;
    public GameObject Boots1;
    public GameObject Boots2;
    public GameObject Pants;

    public void ToggleHelmet1(bool isOn)
    {
        if (Helmet1 != null)

            Helmet1.SetActive(isOn);
    }

    public void ToggleHelmet2(bool isOn)
    {
        if (Helmet2 != null)

            Helmet2.SetActive(isOn);
    }

    public void ToggleChestplate1(bool isOn)
    {
        if (Chestplate1 != null)

            Chestplate1.SetActive(isOn);
    }
    public void ToggleChestplate2(bool isOn)
    {
        if (Chestplate2 != null)

            Chestplate2.SetActive(isOn);
    }

    public void ToggleBoots1(bool isOn)
    {
        if (Boots1 != null)

            Boots1.SetActive(isOn);
    }

    public void ToggleBoots2(bool isOn)
    {
        if (Boots2 != null)

            Boots2.SetActive(isOn);
    }

    public void TogglePants(bool isOn)
    {
        if (Pants != null)

            Pants.SetActive(isOn);
    }
}
