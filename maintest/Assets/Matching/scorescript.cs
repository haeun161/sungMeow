using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scorescript : MonoBehaviour
{
    public TextMeshProUGUI scoreText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (GameController1.score > 0 )
            scoreText.text  = "�����̰� ũ����Ż " + GameController1.score + "���� �����ߴٳ�!";
        else
            scoreText.text = "�����̰� ũ����Ż " + 1 + "���� �����ߴٳ�!";
    }
}
