using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpDownimg : MonoBehaviour
{
    public GameObject up,down;
    Vector3 dir, origin;
    // Start is called before the first frame update
    void Start()
    {
        up.SetActive(false);
        down.SetActive(false);  
    }

    // Update is called once per frame
    void Update()
    {
        if (UpAndDownBtnType.updown == 1)
        {
            origin = up.transform.position;
            Debug.Log("up나타나야..");
            up.SetActive(true);
            up.transform.Translate(Vector3.up * 0.1f);
            Invoke("resetAnimUp", 0.5f);

        }
        else if(UpAndDownBtnType.updown == -1)
            {
                origin = down.transform.position;
                Debug.Log("down나타나야..");
                down.SetActive(true);
                down.transform.Translate(Vector3.down * 0.1f);
                Invoke("resetAnimDown", 0.5f);

            }
    }
    public void resetAnimUp()
    {
        up.SetActive(false);
        up.transform.position = origin;
        UpAndDownBtnType.updown = 0;
    }
    public void resetAnimDown()
    {
        down.SetActive(false);
        down.transform.position = origin;
        UpAndDownBtnType.updown = 0;
    }
}
