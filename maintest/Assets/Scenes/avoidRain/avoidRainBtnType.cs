using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class avoidRainBtnType : MonoBehaviour
{

    public avoidRainBTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case avoidRainBTNType.start1:
                Debug.Log("시작1");
                SceneManager.LoadScene("avoidRain2");
                break;
            case avoidRainBTNType.start2:
                SceneManager.LoadScene("avoidRain3");
                Debug.Log("시작2");
                break;
            case avoidRainBTNType.left:
                Debug.Log("왼쪽");
                break;
            case avoidRainBTNType.right:
                Debug.Log("오른쪽");
                break;
            case avoidRainBTNType.up:
                Debug.Log("위");
                break;
            case avoidRainBTNType.down:
                Debug.Log("아래");
                break;
            case avoidRainBTNType.menu:
                SceneManager.LoadScene("ChooseMiniGame");
                break;
            case avoidRainBTNType.retry:
                SceneManager.LoadScene("avoidRain2");
                break;

        }
    }
    // Start is called before the first frame update
//    void Start()
 //   {
        
 //   }

    // Update is called once per frame
  //  void Update()
  //  {
        
   // }
}
