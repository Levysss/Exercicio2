using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Aliens
{
    QUATRO_BRAÇOS,
    FANTASMATICO,
    ULTRA_T,
    MASSA_CINZENTA

}

public class Interface : MonoBehaviour
{
    
    
    void Update()
    {
        AliemSelecionado();
    }
    private void AliemSelecionado()
    {
        if(Input.GetKeyUp(KeyCode.W))
        {
            //fantasmatico
            Debug.Log("Fantasmatico");
        }
        else if(Input.GetKeyUp(KeyCode.S))
        {
            //Massa cinzenta
             Debug.Log("Massa Cinzenta");
        }
        else if(Input.GetKeyUp(KeyCode.A))
        {
            //Quatro braços
             Debug.Log("Quatro Braços");
        }
        else if(Input.GetKeyUp(KeyCode.D))
        {
            //ultra T
             Debug.Log("Ultra T");
        }
        else
        {
            Debug.Log("Nem um alien Selecionado");
        }
    }
}


