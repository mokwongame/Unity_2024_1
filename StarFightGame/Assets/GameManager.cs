using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    int score = 0;
    public TMP_Text textScore;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public int getScore() { return score; }
    public void incScore()
    {
        score++;
        showScore();
    }
    public void decScore()
    {
        score--;
        showScore();
    }
    public void showScore()
    {
        textScore.text = score.ToString();
    }
}
