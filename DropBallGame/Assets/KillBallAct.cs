using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBallAct : MonoBehaviour
{
    public float killTime = 10.0f;
    // Start is called before the first frame update
    void Start()
    {
        // gameObject�� GameObject�� �ٸ�; GameObject�� Ŭ����(�ڷ���, ���赵); gameObject�� GameObject�� ������ ����(�ν��Ͻ�)
        //Destroy(gameObject, 10.0f); // 10���Ŀ� gameObject �ı�
        Destroy(gameObject, killTime);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
