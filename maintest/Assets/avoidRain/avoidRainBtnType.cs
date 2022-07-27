using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class avoidRainBtnType : MonoBehaviour
{

    public avoidRainBTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case avoidRainBTNType.start1:
                Debug.Log("시작1");
                break;
            case avoidRainBTNType.start2:
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
