using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effet : MonoBehaviour
{
    private GameObject Vitesse;
    
     void OnTriggerEnter2D(Collider2D trig){
        if(trig.gameObject.CompareTag("Player")){
            float pspeed = GameObject.Find("Player").GetComponent<NewBehaviourScript>().moveSpeed + 20f;
            GameObject.Find("Player").GetComponent<NewBehaviourScript>().moveSpeed = pspeed;
            Invoke ("ralentit", 7f);
            GetComponent<Renderer>().enabled = false; 
            GetComponent<Collider2D>().enabled = false; 

        }
    }
    void ralentit(){
        GameObject.Find("Player").GetComponent<NewBehaviourScript>().moveSpeed = 25f;
        Destroy(gameObject);
    }
} 
