using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Loading : MonoBehaviour
{
    public GameObject origin;
    

    private void Start()
    {
        Invoke("playing", 15f);
    }

    public void playing()
    {
        origin.SetActive(false);
    }
    void Update()
    {
       
    }

}

