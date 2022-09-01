using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
   [SerializeField] private GameObject bullet;
   [SerializeField]  private float _canFire=-1f;
   [SerializeField]  private float _fireRate =0.15f;
      [SerializeField]  private float lives=3;
    
void FireBullets(){
      
        Instantiate(bullet,transform.position,Quaternion.identity);
        _canFire = Time.time+_fireRate;
}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && Time.time >_canFire){
            FireBullets();
        }
    }
}
