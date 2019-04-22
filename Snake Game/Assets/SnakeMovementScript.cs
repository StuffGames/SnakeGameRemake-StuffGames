using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnakeMovementScript : MonoBehaviour
{

    private Rigidbody2D rb;
    private Transform tr;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        StartCoroutine(Movement());
    }

    public IEnumerator Movement()
    {
        transform.position = new Vector2(transform.position.x, transform.position.y + 0.25f);//WHAT IS HAPPENING????!?!?!
        yield return new WaitForSeconds(1);
    }

}
