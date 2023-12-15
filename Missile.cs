using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
   public int speed = 5;

   

    // Update is called once per frame
    void Update()
    {
        Destroy(gameObject,3);
        transform.position += transform.forward * speed * Time.deltaTime;

    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy (gameObject);
        Destroy(other.gameObject);
    }
}
