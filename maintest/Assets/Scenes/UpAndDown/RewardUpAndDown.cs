using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RewardUpAndDown : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI rewardTextUpAndDown;
    public TextMeshProUGUI answerText;
    // Start is called before the first frame update
    void Start()
    {
        answerText.text += UpAndDownBtnType.answer;
        StartCoroutine(Web.updateCrystal(Web.realusername, UpAndDownBtnType.score));
    }


    // Update is called once per frame
    void Update()
    {
      
        if (UpAndDownBtnType.score != 0)
            rewardTextUpAndDown.text = "성냥이가 크리스탈 " + UpAndDownBtnType.score + "개를 선물했다냥!";
     
    }
}
