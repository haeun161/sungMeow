using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class ChooseMiniGameBtnType : MonoBehaviour
{

    public ChooseMiniGameBTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case ChooseMiniGameBTNType.AvoidRain:
                Debug.Log("CatdontlikeRain:(");
                SceneManager.LoadScene("avoidRain1");
                break;
            case ChooseMiniGameBTNType.FindACat:
                Debug.Log("findcat!");
                SceneManager.LoadScene("FindtheCat1");
                Debug.Log("findcat!");
                break;
            case ChooseMiniGameBTNType.UpAndDown:
                SceneManager.LoadScene("UpAndDown");
                Debug.Log("updown");
                break;
            case ChooseMiniGameBTNType.Mate:
                SceneManager.LoadScene("Matching1");
                Debug.Log("MAteGame");
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
