using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Player : MonoBehaviour
{
    public GameObject gameover;
    string dir;
    public void Press_up()
    {
        dir = "up";
    }
    public void Press_down()
    {
        dir = "down";
    }
    public void Press_left()
    {
        dir = "left";
    }
    public void Press_right()
    {
        dir = "right";
    }
    public void Press_nomal()
    {
        dir = "null";
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        Destroy(collider.gameObject);
        Debug.Log("GAME OVER");
        gameover.SetActive(true);
        Handheld.Vibrate();
        //나중에 살려야함
        Invoke("changeScene", 0.5f);
    }
    void changeScene()
    {
        SceneManager.LoadScene("avoidRain4");
    }
    // Start is called before the first frame update
    void Start()
    {
        gameover.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 myPos = transform.position;
        //Debug.Log("위치:" + transform.position);
        if (dir == "up" && (myPos.y<=54.53))
        {
            transform.Translate(Vector3.up*0.4f);
        }
        else if (dir == "left" && (myPos.x >= -21))
        {
            transform.Translate(Vector3.left * 0.4f);
        }
        else if (dir == "down" && (myPos.y >= -49.61))
        {
            transform.Translate(Vector3.down * 0.4f);
        }
        else if (dir=="right" && (myPos.x <= 19))
        {
            transform.Translate(Vector3.right * 0.4f);
        }
    }
}
