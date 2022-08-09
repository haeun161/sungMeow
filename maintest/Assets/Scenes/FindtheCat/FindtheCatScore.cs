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
            scoreText.text = "아쉽지만 크리스탈을 못받았습니다...";
        else
            scoreText.text = "집사는 크리스탈 "+ FindtheCatBtnType.score + "개를 획득하였다!";
    }
}
