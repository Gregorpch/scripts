using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{  // ��������
    public int health = 5;

    //������� NPC
    public int level = 1;

    //��������
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        //���-�� �� �� ������
        health += level;

        //��������� ������� �� NPC
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *  speed);
    }
}