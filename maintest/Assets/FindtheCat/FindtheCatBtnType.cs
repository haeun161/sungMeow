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
                Debug.Log("���� ����");
                break;
            case FindtheCatBTNType.TreeButton:
                Debug.Log("���� ���� ����̰� �־��!");
                break;
            case FindtheCatBTNType.RoofButton:
                Debug.Log("���� ���� ����̰� �־��!");
                break;
            case FindtheCatBTNType.WallButton:
                Debug.Log("���� ���� ����̰� �־��!");
                break;

        }
    }
}
