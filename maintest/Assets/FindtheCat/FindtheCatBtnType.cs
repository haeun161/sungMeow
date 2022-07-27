using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindtheCatBtnType : MonoBehaviour
{
    public FindtheCatBTNType currentType;
    public void OnBtnClick()
    {
        Debug.Log("1차 테스트");
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
                if (result == 0)
                {
                    Debug.Log("고양이를 찾았어요!!");
                }
                else
                {
                    Debug.Log("아쉽지만 고양이가 여기에는 없어요:(");
                }
                break;

            case FindtheCatBTNType.RoofButton:
                if (result == 1)
                {
                    Debug.Log("고양이를 찾았어요!!");
                }
                else
                {
                    Debug.Log("아쉽지만 고양이가 여기에는 없어요:(");
                }
                break;
            case FindtheCatBTNType.WallButton:
                if (result == 2)
                {
                    Debug.Log("고양이를 찾았어요!!");
                }
                else
                {
                    Debug.Log("아쉽지만 고양이가 여기에는 없어요:(");
                }
                break;

        }
    }
}
