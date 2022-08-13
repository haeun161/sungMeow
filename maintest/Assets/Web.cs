using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using UnityEngine.SceneManagement;
// UnityWebRequest.Get example

// Access a website and use UnityWebRequest.Get to download a page.
// Also try to download a non-existing page. Display the error.

public class Web : MonoBehaviour
{
    public static string realusername;
    void Start()
    {
        //StartCoroutine(GetDate());
        //StartCoroutine(Login("haeun","pw1234"));
        //StartCoroutine(RegisterUser("subin2", "pw12342", "1@gmail.com"));
    }

    public void ShowUserItems()
    {
        StartCoroutine(GetItemsName(MainScript.Instance.UserInfo.UserName));
    }

    IEnumerator GetDate()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost:8080/UnityBackendTutorial/GetUsers.php"))
        {
            // Request and wait for the desired page.
            yield return www.Send();

            if(www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                byte[] results = www.downloadHandler.data;
            }
           
        }
    }
    public IEnumerator GetUsers()
    {
        using (UnityWebRequest www = UnityWebRequest.Get("http://localhost:8080/UnityBackendTutorial/GetUsers.php"))
        {
            // Request and wait for the desired page.
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);

                byte[] results = www.downloadHandler.data;
            }

        }
    }
    public IEnumerator Login(string username, string password)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPassword", password);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/UnityBackendTutorial/Login.php", form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                //MainScript.Instance.UserInfo.SetInfo(username, password);
                MainScript.Instance.UserInfo.SetUsername(username);

                // MainScript.Instance.UserInfo.SetUsername(www.downloadHandler.text);
                //MainScript.Instance.UserInfo.SetPassword(password);

                if (www.downloadHandler.text.Contains("wrong password") || www.downloadHandler.text.Contains("Username does not exist."))
                {
                    Debug.Log("Try Again");
                }

                //If we logged in correctly
                else
                {
                    SceneManager.LoadScene("Main");
                    realusername = username;
                    //MainScript.Instance.UserProfile.SetActive(true);
                    //MainScript.Instance.Login.gameObject.SetActive(false);
                }


            }
        }
    }
    public IEnumerator RegisterUser(string username, string password, string email)
    {
        WWWForm form = new WWWForm();
        form.AddField("loginUser", username);
        form.AddField("loginPassword", password);
        form.AddField("loginEmail", email);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/UnityBackendTutorial/RegisterUser.php", form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
            }
        }
    }
    public IEnumerator GetItemsName(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);

        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/UnityBackendTutorial/GetItemsName.php", form))
        {
            // Request and wait for the desired page.
            yield return www.Send();

            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                string jsonArray = www.downloadHandler.text;

                //Call callback function to pass results
            }

        }
    }
    public static IEnumerator getUsersItems(string username, string itemname, int itemindex)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("itemname", itemname);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/UnityBackendTutorial/GetUsersItems.php", form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log(www.downloadHandler.text);
                
                if (www.downloadHandler.text.Contains("1"))
                {
                    useritem.hasitem[itemindex] = 1;
                }
                

            }
        }
    }
    public static IEnumerator getCrystal(string username)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/UnityBackendTutorial/GetCrycstal.php", form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                Debug.Log("cryctal: "+www.downloadHandler.text);
                useritem.realcrystal = int.Parse(www.downloadHandler.text);
                Debug.Log("crystal" + useritem.realcrystal);

            }
        }
    }
    public static IEnumerator updateCrystal(string username, int crystal)
    {
        WWWForm form = new WWWForm();
        form.AddField("username", username);
        form.AddField("crystal", crystal);
        using (UnityWebRequest www = UnityWebRequest.Post("http://localhost:8080/UnityBackendTutorial/UpdateCrystal.php", form))
        {
            yield return www.SendWebRequest();
            if (www.isNetworkError || www.isHttpError)
            {
                Debug.Log(www.error);
            }
            else
            {
                getCrystal(username);

            }
        }
    }

}

