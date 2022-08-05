using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class BtnType : MonoBehaviour
{
    public BTNType currentType;

    public void OnBtnClick()
    {
        switch (currentType)
        {
            case BTNType.Home:
                Debug.Log("인벤토리로 이동");
                SceneManager.LoadScene("Inventory");
                break;
            case BTNType.Main:
                Debug.Log("메인홈으로 이동");
                SceneManager.LoadScene("Main");
                break;
            case BTNType.GoMiniGame:
                Debug.Log("미니게임하기");
                SceneManager.LoadScene("ChooseMiniGame");
                break;
            case BTNType.GoAR:
                Debug.Log("모험떠나기");
                SceneManager.LoadScene("Map");
                break;

        }
    }
}

