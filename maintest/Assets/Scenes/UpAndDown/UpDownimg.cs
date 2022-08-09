using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UpDownimg : MonoBehaviour
{
    public GameObject up,down,correct, nocorrect;
    Vector3 dir, origin;
    // Start is called before the first frame update
    void Start()
    {
        up.SetActive(false);
        down.SetActive(false);
        correct.SetActive(false);
        nocorrect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if ((UpAndDownBtnType.updown == 1) && (UpAndDownBtnType.count>0))
        {
            origin = up.transform.position;
            up.SetActive(true);
            up.transform.Translate(Vector3.up * 0.6f);
            Invoke("resetAnimUp", 1f);

        }
        else if((UpAndDownBtnType.updown == -1) && (UpAndDownBtnType.count > 0))
            {
                origin = down.transform.position;
                down.SetActive(true);
                down.transform.Translate(Vector3.down * 0.6f);
                Invoke("resetAnimDown", 1f);

            }
        else if ((UpAndDownBtnType.updown == 2) && (UpAndDownBtnType.count > 0))
        {
            origin = correct.transform.position;
            correct.SetActive(true);
            Invoke("resetAnimCorrect", 1f);

        }
        else if ( UpAndDownBtnType.count == 0)
        {
            Debug.Log("½Ç~ÆÐ!");
            nocorrect.SetActive(true);
            SceneManager.LoadScene("UpAndDown4");
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
    public void resetAnimCorrect()
    {
   
        correct.SetActive(false);
        UpAndDownBtnType.updown = 0;
    }

}
