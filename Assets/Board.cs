using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    private bool descendo = false;
    private bool subindo = false;
    float tempoPassado = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(descendo)
        {
            transform.Translate(Vector3.down * Time.deltaTime * 1);
            tempoPassado += Time.deltaTime;
            if(tempoPassado > 3)
            {
                descendo = false;
                subindo = true;
                tempoPassado = 0;
            }
        }

        if (subindo)
        {
            transform.Translate(Vector3.up * Time.deltaTime * 1);
            tempoPassado += Time.deltaTime;
            if (tempoPassado > 3)
            {
                subindo = false;
                tempoPassado = 0;
            }
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            descendo = true;
        }
    }
}
