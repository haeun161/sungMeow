using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MatchingBtnType : MonoBehaviour
{
    public MatchingBTNType currentType;
    public void OnBtnClick()
    {
        switch (currentType)
        {
            case MatchingBTNType.startBtn:
                Debug.Log("Ω√¿€1");
                SceneManager.LoadScene("Matching4");
                break;
            case MatchingBTNType.menu:
                SceneManager.LoadScene("ChooseMiniGame");
                break;
            case MatchingBTNType.retry:
                SceneManager.LoadScene("Matching2");
                break;
        }
    }
}
