using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bases : MonoBehaviour
{
    private int bulletCollision = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Alien"){
            Destroy(gameObject);
        }
        if(collision.tag == "Tiro"){
            bulletCollision += 1;
            Destroy(collision.gameObject);
            if(bulletCollision >= 3){
                Destroy(gameObject);
            }
        }
    }
}
