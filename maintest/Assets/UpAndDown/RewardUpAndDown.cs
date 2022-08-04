using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RewardUpAndDown : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI rewardTextUpAndDown;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (UpAndDownBtnType.score != 0)
            rewardTextUpAndDown.text = "성냥이가 크리스탈 " + UpAndDownBtnType.score + "개를 선물했다냥!";
     
    }
}
