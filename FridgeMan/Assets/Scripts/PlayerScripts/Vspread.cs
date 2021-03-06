using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vspread : MonoBehaviour
{
    float Cooldown = 5f;
    float timer;


    // Start is called before the first frame update
    void Start()
    {
        timer = Cooldown;
        //GetComponent<BoxCollider>().enabled = false;

        AttackSequence();
    }

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.K) && timer <= 0)
        {
            StartCoroutine(AttackSequence());
            
            timer = Cooldown;
        }

    }

    private void AttackBegin()
    {

    }

    public IEnumerator AttackSequence()
    {
        //This triggers the box collider & mesh renderer to turn on for a brief period
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<MeshRenderer>().enabled = true;
        //GetComponent<SpriteRenderer>().enabled = true;

        yield return new WaitForSeconds(0.5f);
        
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        

    }
}
