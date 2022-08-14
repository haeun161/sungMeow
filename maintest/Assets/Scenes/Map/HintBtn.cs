using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HintBtn : MonoBehaviour
{
    // Start is called before the first frame update
    public void HintButtonClick()
    {

        if (GPS.HintName == "HintName1") {SceneManager.LoadScene("Hint1", LoadSceneMode.Single); }

        if (GPS.HintName == "HintName2") { SceneManager.LoadScene("Hint2", LoadSceneMode.Single); }
        if (GPS.HintName == "HintName3") { SceneManager.LoadScene("Hint3", LoadSceneMode.Single); }
        if (GPS.HintName == "HintName4") { SceneManager.LoadScene("Hint4", LoadSceneMode.Single); }
        if (GPS.HintName == "HintName5") { SceneManager.LoadScene("Hint5", LoadSceneMode.Single); }
        if (GPS.HintName == "HintName6") { SceneManager.LoadScene("Hint6", LoadSceneMode.Single); }
        if (GPS.HintName == "HintName7") { SceneManager.LoadScene("Hint7", LoadSceneMode.Single); }

    }
}
