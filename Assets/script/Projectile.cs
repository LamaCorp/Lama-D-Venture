using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    public float speed;
    public float lifeTime;

    private void Start()
    {
        Invoke("DestroyProjectile", lifeTime);
    }

    private void Update()
{
        transform.Translate(Vector2.up * speed * Time.deltaTime);
        if(speed < 1){
            Destroy(gameObject);}
        Invoke ("destruction", 1f);
}
    void destruction(){
        Destroy(gameObject);
    }

}

