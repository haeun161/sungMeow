using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class UpAndDownBtnType : MonoBehaviour
{

    public UpAndDownBTNType currentType;
 //   int num = new Random(0,100);
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case UpAndDownBTNType.Start:
                Debug.Log("UpDownSTart");
                SceneManager.LoadScene("UpAndDown3");
                break;
            case UpAndDownBTNType.num1:
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


        }
    }

}
