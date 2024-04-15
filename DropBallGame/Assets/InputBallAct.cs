using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputBallAct : MonoBehaviour
{
    public GameObject ball;
    public GameObject cubeColor;
    Renderer cubeRend;
    // red, green, blue, white, black ������ ���� ��ȭ
    int colorSize = 5; // ���� ����
    int colorIndex = 0; // ���� ���� ��ġ: 0, 1, 2, 3, 4(=5-1)

    // Start is called before the first frame update
    void Start()
    {
        cubeRend = cubeColor.GetComponent<Renderer>(); // ������Ʈ cubeColor�� ������Ʈ(Component)�� �����ؼ� Renderer�� ��ȯ
        cubeRend.material.color = Color.red;
    }

    // �����Ӹ��� ȣ���ϴ� �Լ�; ������: ����� �׸�
    // Update is called once per frame
    void Update()
    {
        // ����� �Է� ��ٸ���
        if (Input.GetKeyDown(KeyCode.Space)) // �����̽�(Space)�� ����(KeyDown)��(if)
        {
            makeBall();
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow)) // ���� ȭ��ǥ: ������ �������� ����
        {
            colorIndex--; // colorIndex = colorIndex - 1
            if (colorIndex < 0) colorIndex = colorSize - 1; // 0���� ������ 4�� ����
            cubeRend.material.color = getColor();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow)) // ������ ȭ��ǥ: ������ ���������� ����
        {
            colorIndex++; // colorIndex = colorIndex + 1
            if (colorIndex >= colorSize) colorIndex = 0; // 5���� ũ�ų� ������ 0���� ����
            cubeRend.material.color = getColor();
        }
        else if (Input.GetKeyDown(KeyCode.Escape)) // �̽������� Ű ������ ���� ����
        {
            Application.Quit(); // ���� ��(app, application)�� ����(quit)
        }
    }

    void makeBall()
    {
        // �ν��Ͻ�(instance) �����(instantiate)
        // ���� ���� ������Ʈ�� Transform�� ���� �ν��Ͻ��� transform
        // . �ǹ�: Ŭ������ ���(����, �Լ�)�� �����ϴ� ��ȣ
        GameObject newBall = Instantiate(ball, transform.position, transform.rotation); // ���� ����(Instantiate)�ؼ� GameObject�� newBall�� �ʱ�ȭ(=)
        Renderer renderer = newBall.GetComponent<Renderer>();
        renderer.material.color = getColor();
    }

    Color getColor()
    {
        // switch ������ if, else ������ ����ȭ��Ŵ
        switch (colorIndex)
        {
            case 0: return Color.red; // if (colorIndex == 0) {...}
            case 1: return Color.green;
            case 2: return Color.blue;
            case 3: return Color.white;
            case 4: return Color.black;
            default: return Color.black;
        }
    }
}
