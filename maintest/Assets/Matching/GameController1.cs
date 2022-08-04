using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController1 : MonoBehaviour
{
    public static int score = 80;
    public static int correctscore = 0;
    public const int columns = 3;
    public const int rows = 4;

    public const float Xspace = 3.4f;
    public const float Yspace = 3.5f;

    [SerializeField] private MatchingImage startObject;
    [SerializeField] private Sprite[] images;

    private int[] Randomiser(int[] locations)
    {
        int[] array = locations.Clone() as int[];
        for (int i = 0; i < array.Length; i++)
        {
            int newArray = array[i];
            int j = Random.Range(i, array.Length);
            array[i] = array[j];
            array[j] = newArray;
        }
        return array;
    }

    private void Start()
    {
        int[] locations = { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 };
        locations = Randomiser(locations);

        Vector3 startPosition = startObject.transform.position;

        for (int i = 0; i < columns; i++)
        {
            for (int j = 0; j < rows; j++)
            {
                MatchingImage gameImage;
                if (i == 0 && j == 0)
                {
                    gameImage = startObject;
                }
                else
                {
                    gameImage = Instantiate(startObject) as MatchingImage;
                }

                int index = j * columns + i;
                int id = locations[index];
                gameImage.ChangeSprite(id, images[id]);

                float positionX = (Xspace * i) + startPosition.x;
                float positionY = (Yspace * j) + startPosition.y;

                gameImage.transform.position = new Vector3(positionX, positionY, startPosition.z);
            }
        }
    }
    private MatchingImage firstOpen;
    private MatchingImage secondOpen;

    //public static int score = 80;
    private int attempts = 0;

    [SerializeField] private TextMesh scoreText;
    [SerializeField] private TextMesh attemptsText;

    public bool canOpen
    {
        get { return secondOpen == null; }
    }
    public void imageOpened(MatchingImage startObject)
    {
        if(firstOpen == null)
        {
            firstOpen = startObject;
        }
        else
        {
            secondOpen = startObject;
            StartCoroutine(CheckGuessed());
        }
    }
    private IEnumerator CheckGuessed()
    {
        if(firstOpen.spriteId == secondOpen.spriteId) //Compare the two Objects 
        {
            score = score + 5;
            correctscore++;
            scoreText.text = score + "point";
            
            if (correctscore == 6)
            {
                SceneManager.LoadScene("Matching5");
            }
        }
        else
        {
            yield return new WaitForSeconds(0.5f); //Start timer
            score = score -5;
            scoreText.text = score + "point";
            firstOpen.Close();
            secondOpen.Close();
        }
        attempts++;
        attemptsText.text = "½Ãµµ: " + attempts;

        firstOpen = null;
        secondOpen = null;
    }
    public void Restart()
    {
        SceneManager.LoadScene("Matching4");
    }
}
