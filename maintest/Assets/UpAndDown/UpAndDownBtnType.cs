using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UpAndDownBtnType : MonoBehaviour
{

    public UpAndDownBTNType currentType;
    static int user = 0;
    static int answer;
    static int please = 0;
    static int count = 3;
    //�̹��� �����

    void play()
    {
        
        if (please == 1)
        {
            if (answer > user)
            {
                Debug.Log("Up");
                user = 0;
                please = 0;
                count -= 1;
                if (count == 0)
                {
                    Debug.Log("��ȸ����!!�Ф�");
                }
            }
            else if (answer < user)
            {
                Debug.Log("Down");
                user = 0;
                please = 0;
                count -= 1;
                if (count == 0)
                {
                    Debug.Log("��ȸ����!!�Ф�");
                }
            }
            else
                Debug.Log("!!!!!!!!!!!!!!!!!!!����!!!!!!!!!!!!!!!!!!!!!");
        }


        //SceneManager.LoadScene("SampleScene");
    }
    public void Getvalue(int value)
    {
        if ( please==0 ) // �ι�°���Է½� 
        {
            please = 1;
            user = value;

        }
        else 
        {
            user *= 10;
            user += value;
            Debug.Log($"�Է°���: {user}");
            play();
        }
    }
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case UpAndDownBTNType.Start:
                Debug.Log("UpDownSTart");
                please = 0;
                answer = Random.Range(0, 100);
                Debug.Log($"�̴ϰ��� ����, ��������: {answer}");
                play();
                SceneManager.LoadScene("UpAndDown3");
                break;
        /*    case UpAndDownBTNType.num1:
                Debug.Log("num1");
                break;
            case UpAndDownBTNType.num2:
                Debug.Log("num2");
                break;
            case UpAndDownBTNType.num3:
                Debug.Log("num3");
                break;
            case UpAndDownBTNType.num4:
                Debug.Log("num4");
                break;
            case UpAndDownBTNType.num5:
                Debug.Log("num5");
                break;
            case UpAndDownBTNType.num6:
                Debug.Log("num6");
                break;
            case UpAndDownBTNType.num7:
                Debug.Log("num7");
                break;
            case UpAndDownBTNType.num8:
                Debug.Log("num8");
                break;
            case UpAndDownBTNType.num9:
                Debug.Log("num9");
                break;
            case UpAndDownBTNType.num0:
                Debug.Log("num0");
                break;
        */

        }
    }

}
