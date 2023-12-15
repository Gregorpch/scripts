using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject fireballPrefab;
    private int health = 10;
    public Transform attackPoint;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("Здоровье игрока: " + health);

        
    }
       
    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

    public int coins = 0;

    public void CollectCoins()
    {
        coin += 1;
        print("coins" + coin);
    }
}
