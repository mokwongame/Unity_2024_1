using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool bCanMakeBall = true; // ���� ���� �� �ִ� ����

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // �� ���� �� �ִ��� Ȯ��
    public bool canMakeBall() { return bCanMakeBall; }

    public void setMakeBall(bool bCanMake) // �� ����� ���� ����
    {
        bCanMakeBall = bCanMake;
    }
}
