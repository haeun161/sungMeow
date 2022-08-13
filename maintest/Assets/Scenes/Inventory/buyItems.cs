using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
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
        price = -9999;
        itemname = "crown";
    }
    public void buysure()
    {

       if (price*-1 <= useritem.realcrystal)
        {
            StartCoroutine(Web.updateCrystal(Web.realusername, price));
            StartCoroutine(Web.updateItem(Web.realusername, itemname));
            SceneManager.LoadScene("inventory");
            price = 0;
        }
        else
        {
            Debug.Log("크라스탈 부족");
            Handheld.Vibrate();
        }
    }
}
