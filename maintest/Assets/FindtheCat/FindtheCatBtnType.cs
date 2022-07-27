using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindtheCatBtnType : MonoBehaviour
{
    public FindtheCatBTNType currentType;
    public void OnBtnClick()
    {
        Debug.Log("1차 테스트");
        int result = Random.Range(0, 3);
        int trial = 0;

        switch (currentType)
        {
            case FindtheCatBTNType.start:
                Debug.Log("게임 시작");
                break;
                
                
            case FindtheCatBTNType.TreeButton:
                if (result == 0)
                {
                    Debug.Log("고양이를 찾았어요!!");
                    trial++;
                }
                else
                {
                    Debug.Log("아쉽지만 고양이가 여기에는 없어요:(");
                    trial++;
                }
                break;

            case FindtheCatBTNType.RoofButton:
                if (result == 1)
                {
                    Debug.Log("고양이를 찾았어요!!");
                    trial++;
                }
                else
                {
                    Debug.Log("아쉽지만 고양이가 여기에는 없어요:(");
                    trial++;
                }
                break;
            case FindtheCatBTNType.WallButton:
                if (result == 2)
                {
                    Debug.Log("고양이를 찾았어요!!");
                    trial++;
                }
                else
                {
                    Debug.Log("아쉽지만 고양이가 여기에는 없어요:(");
                    trial++;
                }
                break;

        }
    }
}
