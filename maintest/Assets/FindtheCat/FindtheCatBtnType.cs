using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindtheCatBtnType : MonoBehaviour
{
    public FindtheCatBTNType currentType;
    public void OnBtnClick()
    {
        Debug.Log("1�� �׽�Ʈ");
        int result = Random.Range(0, 3);

        //for(int trial=0; trial<3;trial++)
        switch (currentType)
        {
            case FindtheCatBTNType.start1:
                Debug.Log("���� ����");
                SceneManager.LoadScene("FindtheCat2");
                break;

            case FindtheCatBTNType.start2:                
                Debug.Log("������ �����մϴ�!");
                SceneManager.LoadScene("FindtheCat3");
                break;

            case FindtheCatBTNType.TreeButton:
                if (result == 0)
                {
                    Debug.Log("����̸� ã�Ҿ��!!");
                }
                else
                {
                    Debug.Log("�ƽ����� ����̰� ���⿡�� �����:(");
                }
                break;

            case FindtheCatBTNType.RoofButton:
                if (result == 1)
                {
                    Debug.Log("����̸� ã�Ҿ��!!");
                }
                else
                {
                    Debug.Log("�ƽ����� ����̰� ���⿡�� �����:(");
                }
                break;
            case FindtheCatBTNType.WallButton:
                if (result == 2)
                {
                    Debug.Log("����̸� ã�Ҿ��!!");
                }
                else
                {
                    Debug.Log("�ƽ����� ����̰� ���⿡�� �����:(");
                }
                break;

        }
    }
}
