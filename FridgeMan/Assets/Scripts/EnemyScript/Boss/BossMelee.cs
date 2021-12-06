using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossMelee : MonoBehaviour
{
    //public Animator monsterAttack;
    //float Cooldown = 0.5f;
    //float timer;
    

    // Start is called before the first frame update
    void Start()
    {
        //timer = Cooldown;
        //GetComponent<BoxCollider>().enabled = false;

        AttackSequence();
        InvokeRepeating("AttackBegin", 5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        //timer -= Time.deltaTime;

    }

    private void AttackBegin()
    {
        StartCoroutine(AttackSequence());

  
        //timer = Cooldown;
    }

    public IEnumerator AttackSequence()
    {
        //This triggers the box collider & mesh renderer to turn on for a brief period
        GetComponent<BoxCollider>().enabled = true;
        GetComponent<MeshRenderer>().enabled = true;
        //GetComponent<SpriteRenderer>().enabled = true;

        yield return new WaitForSeconds(1f);
       // monsterAttack.SetTrigger("MonsterAttack");
        GetComponent<BoxCollider>().enabled = false;
        GetComponent<MeshRenderer>().enabled = false;
        //GetComponent<SpriteRenderer>().enabled = false;

    }
}
