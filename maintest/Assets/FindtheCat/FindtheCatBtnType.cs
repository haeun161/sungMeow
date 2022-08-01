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
        Debug.Log("1차 테스트");
        int result = Random.Range(0, 3);

       void find()
        {
            if (result == 0)
            {
                Debug.Log("고양이는 나무에 숨어있었네요!!");
                SceneManager.LoadScene("FindtheCat5-2");
            }
            if (result == 1)
            {
                Debug.Log("고양이는 지붕에 숨어있었네요!!");
                SceneManager.LoadScene("FindtheCat6-2");
            }
            else
            {
                Debug.Log("고양이는 담장 위에 숨어있었네요!!");
                SceneManager.LoadScene("FindtheCat7-2");
            }
        }

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

                if (result == 0)
                {
                    Debug.Log("고양이를 찾았어요!!");
                    SceneManager.LoadScene("FindtheCat5-1");
                }
                else
                {
                    Debug.Log("아쉽지만 고양이가 여기에는 없어요:(");
                    find();
                }
                break;

            case FindtheCatBTNType.RoofButton:
                SceneManager.LoadScene("FindtheCat4-2");

                if (result == 1)
                {
                    Debug.Log("고양이를 찾았어요!!");
                    SceneManager.LoadScene("FindtheCat6-1");
                }
                else
                {
                    Debug.Log("아쉽지만 고양이가 여기에는 없어요:(");
                    find();
                }
                break;
            case FindtheCatBTNType.WallButton:
                SceneManager.LoadScene("FindtheCat4-3");
                if (result == 2)
                {
                    Debug.Log("고양이를 찾았어요!!");
                    SceneManager.LoadScene("FindtheCat7-1");
                }
                else
                {
                    Debug.Log("아쉽지만 고양이가 여기에는 없어요:(");
                    find();
                }
                break;
            case FindtheCatBTNType.next:
                Debug.Log("다음페이지로 넘어가기");
                SceneManager.LoadScene("FindtheCat8");
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
