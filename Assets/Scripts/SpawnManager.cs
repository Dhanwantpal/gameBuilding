using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
  public GameObject _enemyPrefab;
   public GameObject _enemyContainer;
   public bool _stopSpawing=true;

    IEnumerator SpawnEnemies(){
      while(_stopSpawing==false) {
       float randomXPosition = Random.Range(-5f,5f);
       Vector3 swapnPosition = new Vector3(randomXPosition,4,0);

       GameObject newEnemy =  Instantiate(_enemyPrefab,swapnPosition,Quaternion.identity);
       newEnemy.transform.parent = _enemyContainer.transform;
        yield return new WaitForSeconds(2);
      }
    }
    // // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnEnemies());
    }

    // // Update is called once per frame
    // void Update()
    // {
        
    // }
}
