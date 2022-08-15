using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class popup : MonoBehaviour
{
    public GameObject Pop0, Pop1, Pop2, Pop3, Pop4, Pop5, Pop6;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (useritem.hasitem[0] == 1)
        {
            Pop0.SetActive(false);
        }
        if (useritem.hasitem[1] == 1)
        {
            Pop1.SetActive(false);
        }
        if (useritem.hasitem[2] == 1)
        {
            Pop2.SetActive(false);
        }
        if (useritem.hasitem[3] == 1)
        {
            Pop3.SetActive(false);
        }
        if (useritem.hasitem[4] == 1)
        {
            Pop4.SetActive(false);
        }
        if (useritem.hasitem[5] == 1)
        {
            Pop5.SetActive(false);
        }
        if (useritem.hasitem[6] == 1)
        {
            Pop6.SetActive(false);
        }
    }
}
