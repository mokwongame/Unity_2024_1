using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    public AudioClip clipShot;
    public AudioClip clipStartGameVoice;
    public TMP_Text textScore;
    bool bCanMakeBall = true; // ���� ���� �� �ִ� ����
    int score = 0; // ����
    //AudioSource audioSource;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        //audioSource = FindAnyObjectByType<AudioSource>(); // GameManager�� AudioSource�� ��Ȱ��
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
    public void incScore() // 1���� ����
    {
        score++;
        showScore();
    }
    public void incBestScore() // 10���� ����
    {
        score += 10;
        showScore();
    }

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

    public void showScore()
    {
        textScore.text = score.ToString(); // ToString(): int�� string���� ����
    }

    public void playBallShot()
    {
        audioSource.PlayOneShot(clipShot, 1.0f); // clipShot: MP3 ������ ����� AudioClip; 1.0f: �Ҹ��� 100%�� ����
    }

    public void playStartGameVoice()
    {
        audioSource.PlayOneShot(clipStartGameVoice, 1.0f);
    }
}
