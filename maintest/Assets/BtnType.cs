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
                Debug.Log("�κ��丮�� �̵�");
                SceneManager.LoadScene("Inventory");
                break;
            case BTNType.Main:
                Debug.Log("����Ȩ���� �̵�");
                SceneManager.LoadScene("Main");
                break;
            case BTNType.GoMiniGame:
                Debug.Log("�̴ϰ����ϱ�");
                SceneManager.LoadScene("ChooseMiniGame");
                break;
            case BTNType.GoAR:
                Debug.Log("���趰����");
                SceneManager.LoadScene("Map");
                break;

        }
    }
}

