using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class buyItems : MonoBehaviour
{
    //public static int[] itemprice = new int[] { 500, 700, 3500, 2000, 1500, 2500, 9999 };
    // Start is called before the first frame update
    public static int price;
    public static string itemname;

    public void buyBowl()
    {
        price = -500;
        itemname = "bowl";
    }
    public void buyFish()
    {
        price = -700;
        itemname = "fish";
    }
    public void buyString()
    {
        price = -3500;
        itemname = "string";
    }
    public void buyScarf()
    {
        price = -2000;
        itemname = "scarf";
    }
    public void buyRibbon()
    {
        price = -1500;
        itemname = "ribbon";
    }
    public void buyPillow()
    {
        price = -2500;
        itemname = "pillow";
    }
    public void buyCrown()
    {
        price = -500;
        itemname = "9999";
    }
    public void buysure()
    {
        StartCoroutine(Web.getCrystal(Web.realusername));
        StartCoroutine(Web.updateCrystal(Web.realusername,price));
    }
}
