using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnUNO : MonoBehaviour
{
    [SerializeField] Transform spawns; 
    void Start(){

    }
    void Update(){
        if(Input.GetKeyDown(KeyCode.P)){
            transform.position = spawns.transform.position;
        }
    }
//que lea la posicion del objeto y darle la condicion
  
}
