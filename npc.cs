using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{  // здоровье
    public int health = 5;

    //уровень NPC
    public int level = 1;

    //скорость
    public float speed = 1.2f;

    // Start is called before the first frame update
    void Start()
    {
        //кол-во хп от уровня
        health += level;

        //программа выводит хп NPC
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * Time.deltaTime *  speed);
    }
}