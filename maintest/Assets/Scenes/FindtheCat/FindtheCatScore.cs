using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class FindtheCatScore : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(FindtheCatBtnType.score);
        if (FindtheCatBtnType.score == 0)
            scoreText.text = "�ƽ����� ũ����Ż�� ���޾ҽ��ϴ�...";
        else
            scoreText.text = "����� ũ����Ż "+ FindtheCatBtnType.score + "���� ȹ���Ͽ���!";
    }
}
