using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FindtheCatBtnType : MonoBehaviour
{
    public FindtheCatBTNType currentType;
    private int trial = 0;

    public void OnBtnClick()
    {
        Debug.Log("1�� �׽�Ʈ");
        int result = Random.Range(0, 3);

       void find()
        {
            if (result == 0)
            {
                Debug.Log("����̴� ������ �����־��׿�!!");
                SceneManager.LoadScene("FindtheCat4-1");
            }
            if (result == 1)
            {
                Debug.Log("����̴� ���ؿ� �����־��׿�!!");
                SceneManager.LoadScene("FindtheCat4-2");
            }
            else
            {
                Debug.Log("����̴� ���� ���� �����־��׿�!!");
                SceneManager.LoadScene("FindtheCat4-3");
            }
        }

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
                    SceneManager.LoadScene("FindtheCat4-1");
                }
                else
                {
                    Debug.Log("�ƽ����� ����̰� ���⿡�� �����:(");
                    find();
                }
                break;

            case FindtheCatBTNType.RoofButton:
                if (result == 1)
                {
                    Debug.Log("����̸� ã�Ҿ��!!");
                    SceneManager.LoadScene("FindtheCat4-2");
                }
                else
                {
                    Debug.Log("�ƽ����� ����̰� ���⿡�� �����:(");
                    find();
                }
                break;
            case FindtheCatBTNType.WallButton:
                if (result == 2)
                {
                    Debug.Log("����̸� ã�Ҿ��!!");
                    SceneManager.LoadScene("FindtheCat4-3");
                }
                else
                {
                    Debug.Log("�ƽ����� ����̰� ���⿡�� �����:(");
                    find();
                }
                break;

        }
        
    }

    void Update()
    {
        //trialText.text = "���� Ƚ�� : " + trial.ToString();
    }

    private void FixedUpdate()
    {
        if (Input.GetButtonDown("Fire1")) trial++;
    }

}
