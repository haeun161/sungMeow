using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MatchingImage : MonoBehaviour
{
    [SerializeField] private GameObject image_unknown;

    public void OnMouseDown()
    {
        if(image_unknown.activeSelf)
        {
            image_unknown.SetActive(false);
        }
    }

    private int _spriteId;
    public int spriteId
    {
        get { return _spriteId; }
    }

    public void ChangeSprite(int id,Sprite image)
    {
        _spriteId = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
}
