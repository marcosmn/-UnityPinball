using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Bouncers")
        {
            ScoreBoard.GetScoreBoard().AdicionarPontuacao(2);
        }
        if (collision.gameObject.tag == "Hurdles")
        {
            ScoreBoard.GetScoreBoard().AdicionarPontuacao(3);
        }
        if (collision.gameObject.tag == "Pipes")
        {
            ScoreBoard.GetScoreBoard().AdicionarPontuacao(5);
        }

        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);
        }
    }
}
