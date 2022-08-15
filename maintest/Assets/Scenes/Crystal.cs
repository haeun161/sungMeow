using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Crystal : MonoBehaviour
{ 
    public TextMeshProUGUI crystalText;
    // Start is called before the first frame update

    private void Awake()
    {
        Debug.Log(MainScript.Instance.UserInfo.UserName);
        StartCoroutine(Web.getCrystal(MainScript.Instance.UserInfo.UserName));
    }
        void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        crystalText.text = useritem.realcrystal.ToString();
    }
}
