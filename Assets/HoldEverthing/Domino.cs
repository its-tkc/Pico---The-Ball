using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Domino : MonoBehaviour
{
    
    Animator anim;
    [SerializeField]float hp = 6f;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collin)
    {
        if(collin.relativeVelocity.magnitude > hp - 2f)
        {
            anim.SetBool("cracked", true);
            ScoreCollector.score += 4;
        }

        if (collin.relativeVelocity.magnitude > hp)
        {
            Destroy(gameObject);
            ScoreCollector.score += 60;
            InventoryManager.coinContainer += 5;
        }
    }
}
