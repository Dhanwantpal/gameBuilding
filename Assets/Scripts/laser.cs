using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class laser : MonoBehaviour
{
    [SerializeField] private float _laserSpeed;
    // Start is called before the first frame update


    void Update()
    {
        transform.Translate(Vector3.up * _laserSpeed * Time.deltaTime);
        if(transform.position.y>2.46f){
          Destroy(gameObject);
        } 
    }

}
