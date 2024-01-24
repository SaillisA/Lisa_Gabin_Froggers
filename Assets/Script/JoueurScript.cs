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

    public GameObject canvaFin;
    public GameObject canvaTuto;

    public Vector2 spawnDuJeu;

    void Start()
    {
        spawnDuJeu = transform.position;
        canvaFin.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.position += Vector3.left * vitesse;
        }
        if (Input.GetKey(KeyCode.RightArrow) )
        {
            transform.position += Vector3.right * vitesse;

        }
        if (Input.GetKey(KeyCode.UpArrow) )
        {
            transform.position += Vector3.up * vitesse;

        }
        if (Input.GetKey(KeyCode.DownArrow) )
        {
            transform.position += Vector3.down * vitesse;

        }
        //a activer pour jouer au froggers de base
        /*
        if(grenouillePerche == false)
        {
            Debug.Log("Je mourru");
            
        }*/


    }
    //a désactiver pour jouer au froggers de base
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Plateforme")
        {
            Debug.Log("Perdue");
            MortDuJoueur();
        }
        if(collision.gameObject.tag == "Fin")
        {
            canvaFin.SetActive(true);
        }

    }

    public void FermerTuto()
    {
        Destroy(canvaTuto);
    }

        //A activer pour jouer au froggers normale
        /*public void OnTriggerEnter2D(Collider2D collision)
        {
            if(collision.gameObject.tag == "Plateforme")
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
            if(collision.gameObject.tag == "Plateforme")
            {
                Debug.Log("Je suis plus sur une plateforme haha");
                transform.SetParent(null);
                grenouillePerche = false;
            }
            if (collision.gameObject.tag == "Sol")
            {
                grenouillePerche = false;
            }
        }*/

        public void MortDuJoueur()
    {
        transform.position = spawnDuJeu;
    }

}
