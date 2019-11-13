using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door : MonoBehaviour
{
    public GameObject godoor;
    public bool ui;

    void Start()
    {
        
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("Player")){
            godoor.GetComponent<Renderer>().enabled = true;
            gameObject.SetActive(false);
            Invoke ("respawn", 2f);
        }
        
    }
     void respawn(){
            godoor.GetComponent<Renderer>().enabled = false;
            gameObject.SetActive(true);
            
        }
}
