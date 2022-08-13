using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class RewardScript : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI rewardText;
    // Start is called before the first frame update
    void Start()
    {
        //rewardText = GetComponent<TextMeshProUGUI>();
        StartCoroutine(Web.updateCrystal(MainScript.Instance.UserInfo.UserName, (int.Parse(GameController.strTime)) * 2));

    }

    // Update is called once per frame
    void Update()
    {
        rewardText.text = "성냥이가 크리스탈 " + (int.Parse(GameController.strTime)) * 2 + "개를 선물했다냥!";
        
    }
}
