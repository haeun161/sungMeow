using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnType : MonoBehaviour
{
    public BTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.Home:
                Debug.Log("홈으로 이동");
                break;
            case BTNType.GoMiniGame:
                Debug.Log("미니게임하기");
                break;
            case BTNType.GoAR:
                Debug.Log("모험떠나기");
                break;

        }
    }
}