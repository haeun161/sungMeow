using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TryImg1 : MonoBehaviour
{
    public Sprite change_img1;
    public Sprite change_img2;
    public Sprite change_img3;
    public Sprite change_img4;
    Image thisImg;
    // Start is called before the first frame update
    void Start()
    {
        thisImg = GetComponent<Image>();
    }

    // Update is called once per frame
    void Update()
    {
        if (UpAndDownBtnType.count == 4)
        {
            thisImg.sprite = change_img1;
        }
        else if (UpAndDownBtnType.count == 3)
        {
            thisImg.sprite = change_img2;
        }
        else if (UpAndDownBtnType.count == 2)
        {
            thisImg.sprite = change_img3;
        }
        else if (UpAndDownBtnType.count == 1)
        {
            thisImg.sprite = change_img4;
        }
    }
}
