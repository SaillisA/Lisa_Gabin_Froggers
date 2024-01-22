using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JoueurScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject joueur;
    public float vitesse;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * vitesse;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.position += Vector3.right * vitesse;

        }
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * vitesse;
        }

        /*
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * vitesse;
        }
        */
    }
}
