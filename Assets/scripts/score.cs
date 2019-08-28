
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform player;

    public Text scoreText;

    private int now = 3;
    private int scorer = 0;

    // Update is called once per frame
    void Start()
    {
        scoreText.text = scorer.ToString();
    }
    void Update()
    {
        InvokeRepeating("AddToScore", 01f, 02f);

    }
    void AddToScore()
    {
        if (now > 0)
        {
            scorer = scorer + 1;
            scoreText.text = scorer.ToString();
        }
    }
}
