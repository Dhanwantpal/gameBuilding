using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class enemyMove : MonoBehaviour
{
    [SerializeField] private float speed=2;
 private void OnTriggerEnter(Collider other) {
        Player player = other.transform.GetComponent<Player>();
        if(other.tag=="Player"){
            player.Damage();
            Destroy(gameObject);      
        }else if(other.tag=="Bullet"){

            Destroy(other.gameObject);
            Destroy(gameObject);  
          
        }
    } 

    void Update()
    {
        transform.Translate(Vector3.down*speed*Time.deltaTime);
  
    }

    
}
