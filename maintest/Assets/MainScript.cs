using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainScript : MonoBehaviour
{    
    public static MainScript Instance;
    public Web Web;
    public UserInfo UserInfo;
    public GPS GPS;
    // Start is called before the first frame update
    void Start()
    {
        Instance = this;
        Web = GetComponent<Web>();
        UserInfo = GetComponent<UserInfo>();
        GPS = GetComponent<GPS>();
    }

}
