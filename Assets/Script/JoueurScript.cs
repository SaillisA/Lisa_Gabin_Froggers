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
        Rigidbody2D rb = GetComponent<Rigidbody2D>();
        
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
        Debug.Log("Oui, tu rentres en collision");
        if(collision.gameObject.tag == "Sol")
        {
            Debug.Log("Je touche le sol !");
        }
    }

}
