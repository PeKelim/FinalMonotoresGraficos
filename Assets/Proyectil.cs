using System.Collections;
using UnityEngine;

public class Proyectil : MonoBehaviour
{
    public float moveSpeed,lifeTime;

    public Rigidbody theRB;


    void Start()
    {

    }
     
    
    void Update()

        {
        theRB.velocity = transform.forward * moveSpeed;

        lifeTime = Time.deltaTime;
       
        if (lifeTime <= 0)

        {
            Destroy(gameObject);
        }

    }
    private void OnTriggerEnter(Collider other)

    {
        Destroy(gameObject);

    }

}    


        