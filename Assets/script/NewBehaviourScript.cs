using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class NewBehaviourScript : MonoBehaviour {


    public float moveSpeed = 1f;
    SpriteRenderer rend;
    Rigidbody2D rb;
    public Animator animator;
    public bool key = false;
    public bool attaque = false;
    public float cooldowntime = 8f;
    public bool touché;
    public GameObject gameOver;
    
    void Start() {
        rb = GetComponent<Rigidbody2D>();
        rend = GetComponent<SpriteRenderer>();
        
    }


    void Update() {

        float h = Input.GetAxis("Vertical") * moveSpeed;
        rb.velocity = new Vector2(h, rb.velocity.y);
        float v = Input.GetAxis("Horizontal") * moveSpeed;
        rb.velocity = new Vector2(v, rb.velocity.x);
        
       
        animator.SetFloat("speed", Mathf.Abs(v));
        animator.SetFloat("speed1", Mathf.Abs(h));
             
    


        if (v > 0) {
            rend.flipX = false;}
            
        
        if (v < 0) {
            rend.flipX = true;}


}

    void OnTriggerEnter2D(Collider2D trig){
        if(trig.gameObject.CompareTag("enemy")){
            touché = true;
        if(trig.gameObject.CompareTag("enemy")){
            if(touché == true){
                Time.timeScale = 0;
                gameOver.SetActive(true);
            }
        }
        GetComponent<Renderer>().enabled = false;
        Invoke("damage", 0.1f);
        }
    }
    
    void damage(){
        
        GetComponent<Renderer>().enabled = true;
        Invoke("damage1", 0.1f);
    
}
    void damage1(){
        
        GetComponent<Renderer>().enabled = false;
        Invoke("damage2", 0.1f);}
    
    void damage2(){
        
        GetComponent<Renderer>().enabled = true;
        Invoke("damage2", 0.1f);}
}