﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 2f;

    // Start is called before the first frame update
    void Start(){
        
    }

    // Update is called once per frame
    void Update(){
        gameObject.transform.position += Vector3.up * speed * Time.deltaTime;
    }

    void OnBecameInvisible(){
        Destroy(gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision){
        if(collision.tag == "Alien"){
            Score.scoreValue += 1;
            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
