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

    public bool grenouillePerche;   //pour savoir si la granouille est sur un sol ou une plateforme

    public Vector2 spawnDuJeu;

    void Start()
    {
        spawnDuJeu = transform.position;
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

        if(grenouillePerche == false)
        {
            Debug.Log("Je mourru");
            
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Tronc")
        {
            Debug.Log("Je suis sur une plateforme hoho");
            transform.position = new Vector3(collision.gameObject.transform.position.x, collision.gameObject.transform.position.y, 0);
            transform.SetParent(collision.transform);
            grenouillePerche = true;
        }
        if(collision.gameObject.tag == "Sol")
        {
            grenouillePerche = true;
        }
    }

    public void OnTriggerExit2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Tronc")
        {
            Debug.Log("Je suis plus sur une plateforme haha");
            transform.SetParent(null);
            grenouillePerche = false;
        }
        if (collision.gameObject.tag == "Sol")
        {
            grenouillePerche = false;
        }
    }

    public void MortDuJoueur()
    {
        transform.position = spawnDuJeu;
    }

}
