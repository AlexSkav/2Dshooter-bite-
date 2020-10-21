using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movimento : MonoBehaviour
{
    private Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movimento();
    }

    public Vector2 jump;
    public float speed = 5f;
    void movimento(){
        transform.Translate(Vector2.right * speed * Time.deltaTime);
        
        if(Input.GetKeyDown("space")){
            rb.AddForce(jump, ForceMode2D.Impulse);
        }
    }
}
