using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Upimg : MonoBehaviour
{
    public GameObject up;
    Vector3 dir, origin;
    // Start is called before the first frame update
    void Start()
    {
        up.SetActive(false);
        origin = up.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if (UpAndDownBtnType.updown == 1)
        {
            Debug.Log("up나타나야..");
            up.SetActive(true);
            up.transform.Translate(Vector3.up * 0.1f);
            Invoke("resetAnimUP", 0.5f);
            
        }
    }
    public void resetAnimUP()
    {
        up.SetActive(false);
        up.transform.position = origin;
        UpAndDownBtnType.updown = 0;
    }
}
