using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaunchMissileAct : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        string objTag = collision.gameObject.tag;
        if (objTag == "Enemy")
        {
            gameManager.incScore();
            print("score = " + gameManager.getScore());
            Destroy(gameObject, 0.1f);
            Destroy(collision.gameObject, 0.5f);
        }
    }
}
