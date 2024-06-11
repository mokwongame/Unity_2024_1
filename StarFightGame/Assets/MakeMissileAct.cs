using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeMissileAct : MonoBehaviour
{
    public GameObject missile;
    float force = 1000.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newMissile = Instantiate(missile, transform.position, transform.rotation);
            Rigidbody2D rb2 = newMissile.GetComponent<Rigidbody2D>();
            rb2.AddForce(Vector2.right * force);
        }
    }
}
