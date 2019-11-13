using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class baie : MonoBehaviour
{
    public GameObject laBaie;
    public Transform shotPointBaie;
    public float offset;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }
    void OnTriggerEnter2D(Collider2D trig){
        if(trig.gameObject.CompareTag("Player")){
            if (Input.GetMouseButton(1)){
                Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
                transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Clamp(rotZ + offset, -110f, -60f));
                Instantiate(laBaie, shotPointBaie.position, transform.rotation);

    }
}
    }
}
