using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletAlien : MonoBehaviour
{
    public float speed = 2f;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        gameObject.transform.position += Vector3.down * speed * Time.deltaTime;
    }

    void OnBecameInvisible(){
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Player"){
            Destroy(gameObject);
            Lives.numLives -= 1;
            if(Lives.numLives == 0){
                Destroy(collision.gameObject);
            }
        }
        if(collision.tag == "Tiro"){
            Destroy(gameObject);
            Destroy(collision.gameObject);
        }
    }
}
