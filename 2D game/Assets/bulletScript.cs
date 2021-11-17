using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bulletScript : MonoBehaviour
{

    float bounces = 0.0f;

    private void OnCollisionEnter2D(Collision2D col)
    {
        if(col.gameObject.name == "bottomCollider")
        {
            Destroy(gameObject);
        }
        if(col.gameObject.name != "bottomCollider" && col.gameObject.tag != "Block")
        {
            bounces++;
            if (bounces >= 6)
            {
                Destroy(gameObject);
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
