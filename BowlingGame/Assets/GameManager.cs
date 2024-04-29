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
    public void incBestScore() { score += 10; } // 10���� ����

    public int getColorSize() { return 8; }

    public Color getColor(int colorIndex)
    {
        // switch ������ if, else ������ ����ȭ��Ŵ
        switch (colorIndex)
        {
            case 0: return Color.red; // if (colorIndex == 0) {...}
            case 1: return Color.green;
            case 2: return Color.blue;
            case 3: return Color.magenta;
            case 4: return Color.yellow;
            case 5: return Color.cyan;
            case 6: return Color.white;
            case 7: return Color.black;
            default: return Color.black;
        }
    }

    public Color getRandomColor()
    {
        //int colorIndex = Random.Range(0, 8); // 0, 1, 2,..., 7(8-1) ������ ���� ����
        int colorIndex = Random.Range(0, getColorSize());
        return getColor(colorIndex);
    }
}
