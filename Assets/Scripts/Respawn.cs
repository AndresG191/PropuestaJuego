using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{
    [SerializeField] Transform spawns; 
    void Start(){

    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.R)){
            transform.position = spawns.transform.position;
        }
    }
//que lea la posicion del objeto y darle la condicion
  
}
