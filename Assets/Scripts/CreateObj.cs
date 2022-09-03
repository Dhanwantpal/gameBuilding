using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateObj : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject objectp;
void Start() {
    for(int i = 0; i < 10; i++) {
         Instantiate(objectp,new Vector3(i*2.0f,0,0),Quaternion.identity);
    }
     
}

}
