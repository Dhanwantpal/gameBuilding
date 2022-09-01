using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
   public float _speed;
 

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0.5f,0);
        // transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y,3.65f,0.5f),0);
    }

    // Update is called once per frame
    void Update()
    {
       
           float horizontalInput = Input.GetAxis("Horizontal");
           float verticlaInput = Input.GetAxis("Vertical");

 if(transform.position.x<-5.46f){
  transform.position = new Vector3(4.41f,transform.position.y,0);
 }
 else if(transform.position.x>4.41f){
 transform.position = new Vector3(-5.46f,transform.position.y,0);
 }

            Vector3 direction = new Vector3(horizontalInput,verticlaInput,0);
           transform.Translate(direction*_speed*Time.deltaTime);
        

        //  
        //    transform.position = new Vector3(transform.position.x,Mathf.Clamp(transform.position.y,3.65f,0.5f),0);



    }
}
