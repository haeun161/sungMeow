using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UpAndDownScript : MonoBehaviour
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
        rewardTextUpAndDown.text = "�����̰� ũ����Ż " + UpAndDownBtnType.score + "���� �����ߴٳ�!";
    }
}
