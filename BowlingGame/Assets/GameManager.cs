using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool bCanMakeBall = true; // ���� ���� �� �ִ� ����
    int score = 0; // ����

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

    public int getScore() { return score; }
    public void setScore(int newScore) { score = newScore; }
    public void incScore() { score++; } // 1���� ����
}
