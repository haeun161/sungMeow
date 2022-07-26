using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindtheCatBtnType : MonoBehaviour
{
    public FindtheCatBTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case FindtheCatBTNType.start:
                Debug.Log("게임 시작");
                break;
            case FindtheCatBTNType.TreeButton:
                Debug.Log("나무 위에 고양이가 있어요!");
                break;
            case FindtheCatBTNType.RoofButton:
                Debug.Log("지붕 위에 고양이가 있어요!");
                break;
            case FindtheCatBTNType.WallButton:
                Debug.Log("담장 위에 고양이가 있어요!");
                break;

        }
    }
}
