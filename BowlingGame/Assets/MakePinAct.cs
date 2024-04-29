using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakePinAct : MonoBehaviour
{
    public GameObject pin;
    GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindAnyObjectByType<GameManager>();
        InvokeRepeating("makePin", 1.0f, 5.0f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void makePin()
    {
        // Pin�� �����Ǵ� ��ġ�� ������(Random Ŭ���� Ȱ��)�� ����
        Vector3 vector3 = new Vector3(); // C�� �ٸ��� C#������ ������ �ݵ�� �ʱ�ȭ(=)�ؼ� ��� ��; new�� ���ο� �ν��Ͻ�(Ŭ������ ������ ���, ����) ����
        vector3.x = Random.Range(-8.5f, 8.5f); // �¿�
        vector3.y = Random.Range(3.0f, 10.0f); // ����(����)
        vector3.z = Random.Range(-5.0f, 10.0f); // ����
        // transform�� ���� ���� ������Ʈ�� PinPosition�� ����� Transform
        //Instantiate(pin, transform.position, transform.rotation);
        GameObject newPin = Instantiate(pin, vector3, transform.rotation); // 3������ ������ ��ġ�� vector3�� �����
        Renderer rend = newPin.GetComponent<Renderer>();
        rend.material.color = gameManager.getRandomColor();
    }
}
