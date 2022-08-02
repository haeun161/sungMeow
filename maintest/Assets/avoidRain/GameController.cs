using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject raindropPrefeb;
    public Text uiTime;
    public static string strTime;
    //public GameObject uiStartGameObject;
    // Start is called before the first frame update

    int sec;

    void Start()
    {
        sec = 0;
        InvokeRepeating("MakeRaindrop", 0f, 1.5f);
        InvokeRepeating("SetTime", 1f, 1f);
    }

    void SetTime()
    {
        sec = sec + 1;
        uiTime.text = ""+sec;
        strTime = uiTime.text;
    }
    void MakeRaindrop()
    {
        GameObject raindrop;

        float switchValue = Random.value;
        float xValue = Random.Range(-900f, 900f);
        float yValue = Random.Range(-1600f, 1600f);

        //Debug.Log("switchValue: " + switchValue + ", xValue: " + xValue + ", yValue: " + yValue);

        if (switchValue > 0.5f)
        {
            if (Random.value > 0.5f)
            {
                raindrop = Instantiate(raindropPrefeb, new Vector3(-900f, yValue, 0f), Quaternion.identity) as GameObject;
                //Debug.Log(1);
            }
            else
            {
                raindrop = Instantiate(raindropPrefeb, new Vector3(900f, yValue, 0f), Quaternion.identity) as GameObject;
                //Debug.Log(2);
            }
        }
        else
        {
            if (Random.value > 0.5f)
            {
                raindrop = Instantiate(raindropPrefeb, new Vector3(xValue, -1600f, 0f), Quaternion.identity) as GameObject;
                //Debug.Log(3);
            }
            else
            {
                raindrop = Instantiate(raindropPrefeb, new Vector3(xValue, 1600f, 0f), Quaternion.identity) as GameObject;
                //Debug.Log(4);
            }
        }

        //raindrop = Instantiate(raindropPrefeb, new Vector3(0,0,0), Quaternion.identity) as GameObject;
        raindrop.transform.SetParent(GameObject.FindGameObjectWithTag("Canvas").transform, false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //public void PressStart()
    //{
    //    uiStartGameObject.SetActive(false);
    //}
}
