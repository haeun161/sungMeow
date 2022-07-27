using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("changeScene", 2f);
    }

    void changeScene()
    {
        SceneManager.LoadScene("UpAndDown2");
    }
    // Update is called once per frame
    void Update()
    {

    }
}
