using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon : MonoBehaviour
{
    
    public float offset;
    public GameObject projectile;
    public Transform shotPoint;

    private float timeBtwShots;
    public float startTimeBtwShots;

    private void Update()
    {
        if (timeBtwShots <= 0)
        {
            if (GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX == false){
                if (Input.GetMouseButton(0))
            {
                
                    Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                    float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
                    transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Clamp(rotZ + offset, -90f, -90f));
                    Instantiate(projectile, shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;
            }
        }
        }
        if (timeBtwShots <= 0)
        {
            if (GameObject.Find("Player").GetComponent<SpriteRenderer>().flipX == true){
                if (Input.GetMouseButton(0))
            {
                
                    Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
                    float rotZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;
                    transform.localRotation = Quaternion.Euler(0f, 0f, Mathf.Clamp(rotZ + offset, 90f, 90f));
                    Instantiate(projectile, shotPoint.position, transform.rotation);
                    timeBtwShots = startTimeBtwShots;
            }
        }
        }
        else {
            timeBtwShots -= Time.deltaTime;
        }

       
    }
}