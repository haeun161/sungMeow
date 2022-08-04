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
        scoreText.text  = "성냥이가 크리스탈 " + GameController1.score + "개를 선물했다냥!";
    }
}
