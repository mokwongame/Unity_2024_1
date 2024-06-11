using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMissileAct : MonoBehaviour
{
    GameManager gameManager;
    float xmax = 15.0f;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        float xpos = transform.position.x;
        if (xpos > xmax)
        {
            gameManager.decScore();
            Destroy(gameObject);
        }
    }
}
