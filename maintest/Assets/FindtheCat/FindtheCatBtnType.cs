using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindtheCatBtnType : MonoBehaviour
{
    public FindtheCatBTNType currentType;
    public void OnBtnClick()
    {
        Debug.Log("1�� �׽�Ʈ");
        int result = Random.Range(0, 3);
        int trial = 0;

        switch (currentType)
        {
            case FindtheCatBTNType.start:
                Debug.Log("���� ����");
                break;
                
                
            case FindtheCatBTNType.TreeButton:
                if (result == 0)
                {
                    Debug.Log("����̸� ã�Ҿ��!!");
                    trial++;
                }
                else
                {
                    Debug.Log("�ƽ����� ����̰� ���⿡�� �����:(");
                    trial++;
                }
                break;

            case FindtheCatBTNType.RoofButton:
                if (result == 1)
                {
                    Debug.Log("����̸� ã�Ҿ��!!");
                    trial++;
                }
                else
                {
                    Debug.Log("�ƽ����� ����̰� ���⿡�� �����:(");
                    trial++;
                }
                break;
            case FindtheCatBTNType.WallButton:
                if (result == 2)
                {
                    Debug.Log("����̸� ã�Ҿ��!!");
                    trial++;
                }
                else
                {
                    Debug.Log("�ƽ����� ����̰� ���⿡�� �����:(");
                    trial++;
                }
                break;

        }
    }
}
