using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;


public class FindtheCatBtnType : MonoBehaviour
{
    
    public FindtheCatBTNType currentType;
    public TextMeshProUGUI scoreText;
    int score = 0;


    public static bool prize { get; internal set; }

    //private int trial = 0;
    public void GoToScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName, LoadSceneMode.Single);
    }

    public void OnBtnClick()
    {
        int result = Random.Range(0, 3);

        //for(int trial=0; trial<3;trial++)
        switch (currentType)
        {                
            case FindtheCatBTNType.sceneChange1:
                if (result == 0)
                {
                    GoToScene("FindtheCat5");
                    score = 15;
                }                   

                else
                    GoToScene("FindtheCat8");
                break;

            case FindtheCatBTNType.sceneChange2:
                if (result == 1)
                {
                    GoToScene("FindtheCat6");
                    score = 15;
                }                    
                else
                    GoToScene("FindtheCat8");
                break;

            case FindtheCatBTNType.sceneChange3:
                if (result == 2)
                {
                    GoToScene("FindtheCat7");
                    score = 15;
                }
                else
                    GoToScene("FindtheCat8");
                break;
        }
        
    }

    void Update()
    {
        if (score==0)
            scoreText.text = "아쉽지만 크리스탈을 못받았습니다...";
        else
            scoreText.text = "성냥이가 크리스탈 " + score + "개를 선물했다냥!";
    }

}
