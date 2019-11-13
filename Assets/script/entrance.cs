using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class entrance : MonoBehaviour
{
    public GameObject tp;
	public GameObject Player;
   
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

 void OnTriggerEnter2D(Collider2D trig){
         if(trig.gameObject.CompareTag("Player")){ 
            Player.transform.position = new Vector2 (tp.transform.position.x, tp.transform.position.y);
 }

}
}



