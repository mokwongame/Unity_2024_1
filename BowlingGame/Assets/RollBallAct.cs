using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollBallAct : MonoBehaviour
{
    float moveSpeed = 8.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float xoff = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime; // �¿� ���� �������� �Է�(-1~+1); Time.deltaTime�� ȭ�� �������� �ð�
        transform.Translate(xoff, 0.0f, 0.0f); // x������ xoff��ŭ �̵�
    }
}
