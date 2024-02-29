using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Aliens
{
    QUATRO_BRAÇOS,
    FANTASMATICO,
    ULTRA_T,
    MASSA_CINZENTA,
    HUMANO
    

}

public class Interface : MonoBehaviour
{
    public Input input;
    public Aliens aliens;
    void Update()
    {
        AliemSelecionado();
    }
    private void AliemSelecionado()
    {
        
       if(Input.GetKeyUp(KeyCode.W))
        {
            //fantasmatico
            aliens = Aliens.FANTASMATICO;
            Debug.Log("Fantasmatico");
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            //Massa cinzenta
            aliens = Aliens.MASSA_CINZENTA;
             Debug.Log("Massa Cinzenta");
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            //Quatro braços
            aliens = Aliens.QUATRO_BRAÇOS;
             Debug.Log("Quatro Braços");
        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            //ultra T
            aliens = Aliens.ULTRA_T;
             Debug.Log("Ultra T");
        }
        else if(Input.GetKeyUp(KeyCode.Space))
        {
            //Reset
            aliens = Aliens.HUMANO;
             Debug.Log("Voltou a ser humano");
        }
    }
}


