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
                SceneManager.LoadScene("Matching3");
                break;
        }
    }
}
