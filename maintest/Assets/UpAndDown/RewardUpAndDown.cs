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
            rewardTextUpAndDown.text = "�����̰� ũ����Ż " + UpAndDownBtnType.score + "���� �����ߴٳ�!";
     
    }
}
