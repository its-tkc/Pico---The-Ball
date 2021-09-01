using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pico : MonoBehaviour
{
    [SerializeField] GameObject cloud, panel1;
    public GameObject nextBall;
    
    [SerializeField] float maxDistance = 3f;
    float releaseDelay;
    bool isPressed, firedOnce;
    private Rigidbody2D rb, springRb;
    public SpringJoint2D sj;


    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        sj = GetComponent<SpringJoint2D>();
        springRb = sj.connectedBody;

        releaseDelay = 1 / (sj.frequency* 4);
        rb.Sleep();
        
    }

    void Start()
    {
        Instantiate(cloud, transform.position, Quaternion.identity);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isPressed && !panel1.activeInHierarchy)
        {
            rb.WakeUp();
            DragBall();
        }
    }

    private void DragBall()
    {
      
        Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        float distance = Vector2.Distance(mousePosition, springRb.position);

        if (!firedOnce)
        {
            if (distance > maxDistance)
            {
                Vector2 direction = (mousePosition - springRb.position).normalized;
                rb.position = springRb.position + direction * maxDistance;
            }
            else
            {
                rb.position = mousePosition;
            }
        }
       
    }

    private IEnumerator Release()
    {
        yield return new WaitForSeconds(releaseDelay);
        sj.enabled = false;
        firedOnce = true;
        transform.localScale = new Vector3(0.1f, 0.1f, 0.1f);
     
        yield return new WaitForSeconds(2f);
        if(nextBall != null)
        {
            nextBall.SetActive(true);
        }
        else
        {
            Debug.Log("No Birds Left");
        }
      
        yield return new WaitForSeconds(5f);
        Destroy(gameObject, 1f);
    }

    private void OnMouseDown()
    {
        if (!panel1.activeInHierarchy)
        {
            isPressed = true;
            rb.isKinematic = true;
            if (!firedOnce)
            {
                transform.localScale = new Vector3(0.12f, 0.12f, 0.1f);
            }
        }
        
    }

    private void OnMouseUp()
    {
        if (!panel1.activeInHierarchy)
        {
            isPressed = false;
            rb.isKinematic = false;

            if (!firedOnce)
            {
                StartCoroutine(Release());
            }
        }
          
    }
}
