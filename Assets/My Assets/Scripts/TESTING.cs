using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TESTING : MonoBehaviour
{
    //public GameObject obj;
    // private GameObject inst_obj;
    private void OnTriggerEnter(Collider other)
    {
        
        Destroy(other.gameObject);
       ScoreScript.ScoreValue += 10;
    }
    


}
