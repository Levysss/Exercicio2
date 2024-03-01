using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seletor : MonoBehaviour
{
    private Vector3 initialPosition;
    void Start()
    {
        initialPosition = transform.position;
    }
    
    void Update()
    {
        Muving();
        
    }
    public void Muving()
    {
        
        if(Input.GetKey(KeyCode.W))
        {
            transform.position += Vector3.up * 0.1f;
        }
        else if(Input.GetKey(KeyCode.S))
        {
            transform.position +=  Vector3.down * 0.1f;
        }
        else if(Input.GetKey(KeyCode.A))
        {
            transform.position += Vector3.left *0.1f;
        }
        else if(Input.GetKey(KeyCode.D))
        {
            transform.position += Vector3.right*0.1f;
        }
        else
        {
           transform.position = initialPosition;
        }
    }
}
