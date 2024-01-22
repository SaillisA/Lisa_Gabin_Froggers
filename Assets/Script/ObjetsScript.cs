using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjetsScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objets;

    public float vitesse;
    public Transform limitR;
    public Transform limitL;

    void Start()
    {
        //Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.velocity = Vector3
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * vitesse;

        if (transform.position.x < limitL.position.x)
        {
            transform.position = new Vector2(limitR.position.x, transform.position.y);
        }
        if (transform.position.x > limitR.position.x)
        {
            transform.position = new Vector2(limitL.position.x, transform.position.y);
        }
    }
}
