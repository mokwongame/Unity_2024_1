using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillMissileAct : MonoBehaviour
{
    float xmax = 15.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xpos = transform.position.x;
        if (xpos > xmax)
        {
            Destroy(gameObject);
        }
    }
}
