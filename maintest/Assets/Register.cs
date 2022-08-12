using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class Register : MonoBehaviour
{
    public TMP_InputField UsernameInput;
    public TMP_InputField PasswordInput;
    public TMP_InputField EmailInput;
    public Button RegisterButton;
    // Start is called before the first frame update
    void Start()
    {
        RegisterButton.onClick.AddListener(() => {
            StartCoroutine(MainScript.Instance.Web.RegisterUser(UsernameInput.text, PasswordInput.text, EmailInput.text));
        });
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
