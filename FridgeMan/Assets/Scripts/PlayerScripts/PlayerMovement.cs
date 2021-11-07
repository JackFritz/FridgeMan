using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    float timer;
    float moveDist = 3.5f;      //How much the player is moving//
    float gridWidth = 3.5f;      //Left Right Move limit//
    float gridHeight = 3.5f;     //Up Down Move limit//

    // Start is called before the first frame update
   private void Start()
    {
        timer = 1f;
    }

    // Update is called once per frame
   private void Update()
    {
        timer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.W) && transform.position.z < gridHeight && timer <= 0)
        {
            transform.position += new Vector3(0, 0, moveDist);
            timer = .25f;
        }
        else if (Input.GetKeyDown(KeyCode.S) && transform.position.z > -gridHeight && timer <= 0)
        {
            transform.position += new Vector3(0, 0, -moveDist);
            timer = .25f;
        }
        else if (Input.GetKeyDown(KeyCode.A) && transform.position.x > -gridWidth && timer <= 0)
        {
            transform.position += new Vector3(-moveDist, 0, 0);
            timer = .25f;
        }
        else if (Input.GetKeyDown(KeyCode.D) && transform.position.x < gridWidth && timer <= 0)
        {
            transform.position += new Vector3(moveDist, 0, 0);
            timer = .25f;
        }
    }
}
