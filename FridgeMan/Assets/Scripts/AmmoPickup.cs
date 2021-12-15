using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        moveAmmo();
    
        InvokeRepeating("moveAmmo", 10f, 5f);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.tag == "Player")
        {
            Debug.Log("Moveit");
            transform.position = new Vector3(-7f, 2, 0f);
        }
    }

    void moveAmmo()
    {
        float randomDir = Random.Range(0, 7);

        if (randomDir == 0)
        {
            transform.position = new Vector3(0, 2, 3.5f);
        }

        else if (randomDir == 1)
        {
            transform.position = new Vector3(0, 2, -3.5f);
        }
        else if (randomDir == 2)
        {
            transform.position = new Vector3(0, 2, 0);
        }

        else if (randomDir == 3)
        {
            transform.position = new Vector3(0, 2, 0);
        }

        //Corner Positions //
        else if (randomDir == 4)
        {
            transform.position = new Vector3(3.5f, 2, 3.5f);
        }
        else if (randomDir == 5)
        {
            transform.position = new Vector3(3.5f, 2, -3.5f);
        }
        else if (randomDir == 6)
        {
            transform.position = new Vector3(-3.5f, 2, 3.5f);
        }
        else if (randomDir == 7)
        {
            transform.position = new Vector3(-3.5f, 2, -3.5f);
        }

    }
}