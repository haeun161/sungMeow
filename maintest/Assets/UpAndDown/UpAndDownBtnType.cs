using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UpAndDownBtnType : MonoBehaviour
{

    public UpAndDownBTNType currentType;
    private bool isFirst;
    private bool isFinish;
    public int user = 0;
    void Start()
    {
        isFirst = true;
        isFinish = false;
    }
    void play()
    {

        int answer;
        answer = Random.Range(0, 100);
        Debug.Log($"�̴ϰ��� ����, ��������: {answer}");
        //�Լ�������Ǿ����//
        if (isFinish == true)
        {
            if (answer > user)
            {
                Debug.Log("Up");
            }
            else if (answer < user)
            {
                Debug.Log("Down");

            }
            else
                Debug.Log("!!!!!!!!!!!!!!!!!!!����!!!!!!!!!!!!!!!!!!!!!");
        }


        //SceneManager.LoadScene("SampleScene");
    }
    public void Getvalue(int value)
    {
        if (!isFirst) // �ι�°���Է½� 
        {
            user *= 10;
            user += value;

            isFinish = true;
            Debug.Log($"�Է��� ����: {user}");
            play();
        }

        else ///ù��°�� �Է½�.
        {
            user = 0;
            user += value;
            isFirst = false;
        }
    }
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case UpAndDownBTNType.Start:
                Debug.Log("UpDownSTart");
                isFirst = true;
                isFinish = false;
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