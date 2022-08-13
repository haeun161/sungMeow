using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UserInfo : MonoBehaviour
{
    public string UserName { get; private set; }
    string UserPassword;
    string Email;
    string Crystal;
    
    public void SetUsername(string username)
    {
        UserName = username;
        Debug.Log(UserName);
    }
    public void SetPassword(string userpassword)
    {

        UserPassword = userpassword;
        Debug.Log(UserPassword);
    }
    

    
}
