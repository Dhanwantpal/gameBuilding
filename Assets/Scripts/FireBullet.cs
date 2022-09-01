using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBullet : MonoBehaviour
{
   [SerializeField] private GameObject bullet;
    // Start is called before the first frame update
    void Start()
    {
        
    }
void FireBullets(){
        Instantiate(bullet,transform.position,Quaternion.identity);
}
    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space)){
            FireBullets();
        }
    }
}
