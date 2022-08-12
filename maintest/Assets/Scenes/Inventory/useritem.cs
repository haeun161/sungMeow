using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class useritem : MonoBehaviour
{
    public static int[] hasitem = new int[] { 0,0,0,0,0,0,0 };
    public static string[] itemnames = new string[] { "bowl", "fish", "string", "scarf", "ribbon", "pillow", "crown" };
    public GameObject gameObject0, gameObject1, gameObject2, gameObject3, gameObject4, gameObject5, gameObject6;
    // Start is called before the first frame update
    private void Awake()
    {
        Debug.Log(Web.realusername);
        for (int i = 0; i < itemnames.Length; i++)
        {
            StartCoroutine(Web.getUsersItems(Web.realusername, itemnames[i], i));
        }
       
    }
    void Start()
    {
        string a = null;
        for (int i = 0; i < itemnames.Length; i++)
        {
            a += hasitem[i];
        }
        Debug.Log(a);
        
    }

    // Update is called once per frame
    void Update()
    {
        if (hasitem[0] == 1)
        {
            gameObject0.SetActive(false);
        }
        if (hasitem[1] == 1)
        {
            gameObject1.SetActive(false);
        }
        if (hasitem[2] == 1)
        {
            gameObject2.SetActive(false);
        }
        if (hasitem[3] == 1)
        {
            gameObject3.SetActive(false);
        }
        if (hasitem[4] == 1)
        {
            gameObject4.SetActive(false);
        }
        if (hasitem[5] == 1)
        {
            gameObject5.SetActive(false);
        }
        if (hasitem[6] == 1)
        {
            gameObject6.SetActive(false);
        }
    }
}
