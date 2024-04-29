using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool bCanMakeBall = true; // 공을 만들 수 있는 상태
    int score = 0; // 득점

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    // 공 만들 수 있는지 확인
    public bool canMakeBall() { return bCanMakeBall; }

    public void setMakeBall(bool bCanMake) // 공 만들기 상태 변경
    {
        bCanMakeBall = bCanMake;
    }

    public int getScore() { return score; }
    public void setScore(int newScore) { score = newScore; }
    public void incScore() { score++; } // 1점을 증가
    public void incBestScore() { score += 10; } // 10점을 증가

    public int getColorSize() { return 8; }

    public Color getColor(int colorIndex)
    {
        // switch 구문은 if, else 구문을 간소화시킴
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
        //int colorIndex = Random.Range(0, 8); // 0, 1, 2,..., 7(8-1) 범위의 난수 생성
        int colorIndex = Random.Range(0, getColorSize());
        return getColor(colorIndex);
    }
}
