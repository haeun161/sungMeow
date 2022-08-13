using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HintBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void HintButtonClick()
    {

        if (MainScript.Instance.GPS.HintName == "Hint1") { SceneManager.LoadScene("Hint1");}
        if (MainScript.Instance.GPS.HintName == "Hint2") { SceneManager.LoadScene("Hint2"); }
        if (MainScript.Instance.GPS.HintName == "Hint3") { SceneManager.LoadScene("Hint3"); }
        if (MainScript.Instance.GPS.HintName == "Hint4") { SceneManager.LoadScene("Hint4"); }
        if (MainScript.Instance.GPS.HintName == "Hint5") { SceneManager.LoadScene("Hint5"); }
        if (MainScript.Instance.GPS.HintName == "Hint6") { SceneManager.LoadScene("Hint6"); }
        if (MainScript.Instance.GPS.HintName == "Hint7") { SceneManager.LoadScene("Hint7"); }

    }
}
