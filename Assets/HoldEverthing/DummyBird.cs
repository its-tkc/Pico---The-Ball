using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DummyBird : MonoBehaviour
{
    [SerializeField] GameObject pico1,cloud;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(SwitchAnim());
        if (pico1.activeInHierarchy)
        {
            Instantiate(cloud);
            Destroy(gameObject, 0.01f);
        }
    }

    IEnumerator SwitchAnim()
    {
        yield return new WaitForSeconds(Random.Range(1, 5));
        anim.SetBool("jump", true);

        yield return new WaitForSeconds(Random.Range(1, 5));
        anim.SetBool("jump", false);
    }
}
