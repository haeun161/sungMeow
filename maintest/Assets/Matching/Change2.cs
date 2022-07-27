using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Change2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("changeScene", 3f);
    }

    void changeScene()
    {
        SceneManager.LoadScene("Matching2");
    }
    // Update is called once per frame
    void Update()
    {

    }
}