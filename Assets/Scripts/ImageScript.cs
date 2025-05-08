using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageScript : MonoBehaviour
{
    public GameObject MaleNord;
    public GameObject FemaleNord;
    public Sprite[] spriteArray;



    public void Dropwdown(int index)
    {
        if (index == 0)
        {
            MaleNord.SetActive(true);
            FemaleNord.SetActive(false);
        }
        else if (index == 1)
        {


            FemaleNord.SetActive(true);
            MaleNord.SetActive(false);
        }

    }
    }
  