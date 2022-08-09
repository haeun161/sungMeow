using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class UpAndDownBtnType : MonoBehaviour
{

    public UpAndDownBTNType currentType;
    static int user = 0;
    public static int answer;
    static int please = 0;
    public static int count = 5;
    public static int updown = 0;
    public static int score = 0;

    //이미지 띄우기용

    void play()
    {
        
        if (please == 1)
        {
            if (answer > user)
            {
                updown = 1;
                Debug.Log("Up");
                user = 0;
                please = 0;
                count -= 1;
                if (count == 0)
                {
                    Debug.Log("기회소진!!ㅠㅠ");
                    updown = 0;
                    score = 10;
                }
            }
            else if (answer < user)
            {
                updown = -1;
                Debug.Log("Down");
                user = 0;
                please = 0;
                count -= 1;
                if (count == 0)
                {
                    Debug.Log("기회소진!!ㅠㅠ");
                    updown = 0;
                    score = 10;
                    
                }
            }
            else
            {
                updown = 2;
                if (count == 5)
                    score = 100;
                else if (count == 4)
                    score = 80;
                else if (count == 3)
                    score = 60;
                else if (count == 2)
                    score = 40;
                else if (count == 1)
                    score = 20;
                Debug.Log("!!!!!!!!!!!!!!!!!!!정답!!!!!!!!!!!!!!!!!!!!!");
                Invoke("change", 0.5f);

            }
                
        }


        //SceneManager.LoadScene("SampleScene");
    }
    public void change()
    {
        SceneManager.LoadScene("UpAndDown4");
        updown = 0;
    }
    public void Getvalue(int value)
    {
        if ( please==0 ) // 두번째값입력시 
        {
            please = 1;
            user = value;

        }
        else 
        {
            user *= 10;
            user += value;
            Debug.Log($"입력값은: {user}");
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
                user = 0;
                please = 0;
                count = 5;
                updown = 0;
                score = 0;
                answer = Random.Range(0, 100);
                Debug.Log($"미니게임 시작, 랜덤숫자: {answer}");
                play();
                SceneManager.LoadScene("UpAndDown3");
                break;
            case UpAndDownBTNType.menu:
                SceneManager.LoadScene("ChooseMiniGame");
                break;
            case UpAndDownBTNType.retry:
                SceneManager.LoadScene("UpAndDown2");
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
