using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePinAct : MonoBehaviour
{
    public GameObject pin;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("makePin", 1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void makePin()
    {
        // transform은 현재 게임 오브젝트인 PinPosition이 실행된 Transform
        Instantiate(pin, transform.position, transform.rotation);
    }
}
