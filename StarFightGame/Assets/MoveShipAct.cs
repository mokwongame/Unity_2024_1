using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveShipAct : MonoBehaviour
{
    float speed = 4.0f;
    float ymin = -4.5f;
    float ymax = 4.5f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float yoff = Input.GetAxis("Vertical") * speed * Time.deltaTime;
        float ypos = transform.position.y + yoff;
        if (ypos >= ymin && ypos <= ymax)
        {
            transform.Translate(0.0f, yoff, 0.0f);
        }
    }
}
