using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;

public class JoueurScript : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject joueur;
    public float vitesse;


    public float tempsAttente;
    public float tempsAttenteNecessaire;

    //Collider
    public GameObject SolBase;

    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        tempsAttente += Time.deltaTime;

        if(Input.GetKeyDown(KeyCode.LeftArrow) && tempsAttente > tempsAttenteNecessaire)
        {
            transform.position += Vector3.left * vitesse;
            tempsAttente = 0;
        }
        if (Input.GetKeyDown(KeyCode.RightArrow) && tempsAttente > tempsAttenteNecessaire)
        {
            transform.position += Vector3.right * vitesse;
            tempsAttente = 0;

        }
        if (Input.GetKeyDown(KeyCode.UpArrow) && tempsAttente > tempsAttenteNecessaire)
        {
            transform.position += Vector3.up * vitesse;
            tempsAttente = 0;

        }
        if (Input.GetKeyDown(KeyCode.DownArrow) && tempsAttente > tempsAttenteNecessaire)
        {
            transform.position += Vector3.down * vitesse;
            tempsAttente = 0;

        }

    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Sol")
        {
            Debug.Log("Je touche le sol !");
        }
        if(collision.gameObject.tag == "Tronc")
        {
            Debug.Log("Je touche le tronc");
        }
        if(collision.gameObject.tag == "Lave")
        {
            Debug.Log("Meurt DémonGorgon");
        }
    }

}
