using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreBoard : MonoBehaviour
{
    private int score = 0;

    // Start is called before the first frame update

    public void AdicionarPontuacao(int newScore)
    {
        score += newScore;
        GetComponent<Text>().text = "Score: " + score.ToString();
    }

    private static ScoreBoard instance;
    public static ScoreBoard GetScoreBoard()
    {
        if (instance == null)
        {
            instance = GameObject.Find("ScoreText").GetComponent<ScoreBoard>();
        }

        return instance;
    }
}
