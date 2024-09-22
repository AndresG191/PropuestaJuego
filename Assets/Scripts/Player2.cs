using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
   [SerializeField] float velocidad_rotacion;
    [SerializeField] float velocidad_movimiento;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.UpArrow)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.forward;
        }   else if(Input.GetKey(KeyCode.DownArrow)){
            transform.position += velocidad_movimiento * -1 * Time.deltaTime * transform.forward;
        }
           //izquierda derecha 
         if(Input.GetKey(KeyCode.LeftArrow)){
            transform.position += velocidad_movimiento * -1* Time.deltaTime * transform.right;
        }   else if(Input.GetKey(KeyCode.RightArrow)){
            transform.position += velocidad_movimiento * Time.deltaTime * transform.right;            
        }
            //rotar izquierda - rotar derecha
         if(Input.GetKey(KeyCode.Q)){
            transform.Rotate(0, velocidad_rotacion * Time.deltaTime, 0);
        }   else if(Input.GetKey(KeyCode.E)){
            transform.Rotate(0, -1 * velocidad_rotacion * Time.deltaTime, 0);
        }
    }
        
    
}