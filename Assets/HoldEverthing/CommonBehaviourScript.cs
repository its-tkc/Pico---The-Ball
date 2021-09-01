using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommonBehaviourScript : MonoBehaviour
{
    Vector2 finalPos;
    Rigidbody2D rb;
    bool isPressed, pressedOnce;
    Vector2 initaialPos;
    [SerializeField] float maxDistance = 1.5f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        initaialPos = transform.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (isPressed)
        {
            DragRedBall();
        }

        if (pressedOnce)
        {
            forceAdd();
        }
    }

    void DragRedBall()
    {
        finalPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        float distance = Vector2.Distance(finalPos, initaialPos);




        if (maxDistance > distance)
        {
            Vector2 direction = (finalPos - initaialPos).normalized;
            rb.position = initaialPos + direction * maxDistance;

        }
        else
        {
            transform.position = finalPos;
        }


    }

    private void OnMouseDown()
    {
        isPressed = true;

    }


    private void OnMouseUp()
    {
        isPressed = false;
        pressedOnce = true;
        
    }

    void forceAdd()
    {
        rb.AddForce(-finalPos * 3f);
    }
}
