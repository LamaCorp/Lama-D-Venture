using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clé : MonoBehaviour
{
    
    public int kills;
    GameObject joueur;

    void Start()
    {
       joueur = GameObject.Find("Player");
    }


    void Update()
    {
        if (kills<20){
            GetComponent<Renderer>().enabled = false;
            GetComponent<Collider2D>().enabled = false;
        }

        if (kills>=20){
            GetComponent<Renderer>().enabled = true;
            GetComponent<Collider2D>().enabled = true;
        }
    }

    void OnTriggerEnter2D(Collider2D trig){
        if(trig.CompareTag("Player")){
        joueur.GetComponent<NewBehaviourScript>().key = true;
        Destroy(gameObject);
        
    }
}
}