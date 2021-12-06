using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileScript : MonoBehaviour
{

 //   void OnCollisionEnter(Collision collision)
 //   {
 //   Destroy(gameObject);
 //   }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
    }
}
