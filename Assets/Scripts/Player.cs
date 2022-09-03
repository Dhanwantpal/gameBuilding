using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player : MonoBehaviour
{
   
 
 [SerializeField] private GameObject bullet;
   [SerializeField]  private float _canFire=-1f;
   [SerializeField]  private float _fireRate =0.15f;
      [SerializeField]  private float _playerLives=3;
      [SerializeField] private float _speed;
      public Text lives;
      public Text score;
      float total_lives = 3;
      int _score=0;
    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(0,0,0);
        
      
    }
     public void Damage(){      
         _playerLives--;
          lives.GetComponent<Text>().text = "Lives : "+_playerLives + " / " +total_lives;
         if(_playerLives < 1){
                     Destroy(gameObject);
            }
    }

    public void Score(){
        _score++;
       score.GetComponent<Text>().text="Score : "+ _score;
    }

void FireBullets(){
    //   Bullet creation
        Instantiate(bullet,transform.position,Quaternion.identity);
        _canFire = Time.time+_fireRate;
    }
    // Update is called once per frame
    void Update()
    {
        
// Player Movement
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


// Player Bulllet Fire
        if(Input.GetKeyDown(KeyCode.Space) && Time.time >_canFire){
            FireBullets();
        } 

      



    }


   
}
