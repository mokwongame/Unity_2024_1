using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBallAct : MonoBehaviour
{
    public float killTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        // gameObject는 GameObject는 다름; GameObject는 클래스(자료형, 설계도); gameObject는 GameObject로 생성한 변수(인스턴스)
        //Destroy(gameObject, 10.0f); // 10초후에 gameObject 파괴
        Destroy(gameObject, killTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
