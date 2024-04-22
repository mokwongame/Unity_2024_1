using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeBallAct : MonoBehaviour
{
    public GameObject ball;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            makeBall();
        }
    }

    void makeBall()
    {
        Instantiate(ball, transform.position, transform.rotation);
    }
}
