using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindtheCatBtnType : MonoBehaviour
{
    public FindtheCatBTNType currentType;
    //private int trial = 0;

    public void OnBtnClick()
    {
        int result = Random.Range(0, 3);

        //for(int trial=0; trial<3;trial++)
        switch (currentType)
        {
            case FindtheCatBTNType.start1:
                Debug.Log("게임 시작");
                SceneManager.LoadScene("FindtheCat2");
                break;

            case FindtheCatBTNType.start2:                
                Debug.Log("게임을 시작합니다!");
                SceneManager.LoadScene("FindtheCat3");
                break;

            case FindtheCatBTNType.TreeButton:
                SceneManager.LoadScene("FindtheCat4-1");
                break;

            case FindtheCatBTNType.RoofButton:
                SceneManager.LoadScene("FindtheCat4-2");
                break;

            case FindtheCatBTNType.WallButton:
                SceneManager.LoadScene("FindtheCat4-3");
                break;

            case FindtheCatBTNType.sceneChange1:
                if(result==0)
                    SceneManager.LoadScene("FindtheCat5");
                else
                    SceneManager.LoadScene("FindtheCat8");
                break;

            case FindtheCatBTNType.sceneChange2:
                if (result == 1)
                    SceneManager.LoadScene("FindtheCat6");
                else
                    SceneManager.LoadScene("FindtheCat8");
                break;

            case FindtheCatBTNType.sceneChange3:
                if (result == 2)
                    SceneManager.LoadScene("FindtheCat7");
                else
                    SceneManager.LoadScene("FindtheCat8");
                break;

            case FindtheCatBTNType.prize:
                Debug.Log("크리스탈 획득");
                SceneManager.LoadScene("FindtheCat9");
                break;

            case FindtheCatBTNType.sceneChange4:
                Debug.Log("돌아가기, 다시하기 페이지로 이동");
                SceneManager.LoadScene("FindtheCat10");
                break;
            case FindtheCatBTNType.restart:
                Debug.Log("다시하기");
                SceneManager.LoadScene("FindtheCat2");
                break;
            case FindtheCatBTNType.menu:
                Debug.Log("메뉴로 돌아가기");
                SceneManager.LoadScene("ChooseMiniGame");
                break;
        }
        
    }

    void Update()
    {
        //trialText.text = "시행 횟수 : " + trial.ToString();
    }

    private void FixedUpdate()
    {
        //if (Input.GetButtonDown("Fire1")) trial++;
    }

}
