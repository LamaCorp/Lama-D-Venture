using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioScript : MonoBehaviour
{
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    private float timeBtwShots;
    public float startTimeBtwShots;

    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
    if (timeBtwShots <= 0){
        if(Input.GetMouseButton(0)){
            MusicSource.Play();
            timeBtwShots = startTimeBtwShots;
    }
    }
    else{
        timeBtwShots -= Time.deltaTime;        
    }
}
}
