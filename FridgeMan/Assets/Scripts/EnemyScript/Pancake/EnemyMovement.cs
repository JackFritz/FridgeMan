using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        moveAi();
        InvokeRepeating("moveAi", 3f, 1.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void moveAi()
    {
        float randomDir = Random.Range(0, 7);

        if (randomDir == 0)
        {
            transform.position = new Vector3(11.5f, 1, 3.5f);
        }

        else if (randomDir == 1)
        {
            transform.position = new Vector3(11.5f, 1, -3.5f);
        }
        else if (randomDir == 2)
        {
            transform.position = new Vector3(8f, 1, 0);
        }

        else if (randomDir == 3)
        {
            transform.position = new Vector3(15, 1, 0);
        }

        //Corner Positions //
        else if (randomDir == 4)
        {
            transform.position = new Vector3(8, 1, 3.5f);
        }
        else if (randomDir == 5)
        {
            transform.position = new Vector3(8f, 1, -3.5f);
        }
        else if (randomDir == 6)
        {
            transform.position = new Vector3(15, 1, 3.5f);
        }
        else if (randomDir == 7)
        {
            transform.position = new Vector3(15, 1, -3.5f);
        }
    }
}
