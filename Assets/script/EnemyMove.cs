using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class EnemyMove : MonoBehaviour
{
   public float speed;
   private Transform target;
   public bool repéré;
   public float taille;
   public Animator animator;
   private GameObject UI;
   public int value = 10;
    float scoreUI;
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    public int minimum;


    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        UI = GameObject.FindGameObjectWithTag("scoreAmount");
        MusicSource.clip = MusicClip;
    }

    void OnTriggerEnter2D(Collider2D trig)
    {
        if(trig.gameObject.CompareTag("attaque")){
    repéré = true;
    speed = speed - 10;
    Invoke("acce", 1.5f);}
         MusicSource.Play();

        if(trig.gameObject.CompareTag("deadzone")){
            Invoke("stop", 1f);
        }
        }
    

    void Update()
    {
        if (repéré == true){
if(Vector2.Distance(transform.position, target.position) > 8){
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            animator.SetFloat("speed", Mathf.Abs(speed));}
}
        
         
    if(target.position.x > transform.position.x){
        transform.localScale = new Vector2(taille, taille);
     }
     
    else if(target.position.x < transform.position.x){
        transform.localScale = new Vector2(-taille, taille);
     }

     if (speed <= minimum){
     speed = minimum;}
    

}
    void stop(){
        speed = 0;
        scoreUI = int.Parse(UI.GetComponent<Text>().text) + value;
            UI.GetComponent<Text>().text = scoreUI + "";
        GetComponent<Collider2D>().enabled = false;
        Invoke("delet", 0.1f);
    }

    void delet(){
        Destroy(gameObject);

    }

    void acce(){
        speed = speed + 5;
    }
}