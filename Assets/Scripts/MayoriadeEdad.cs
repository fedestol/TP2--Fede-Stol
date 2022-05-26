using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class MayoriadeEdad : MonoBehaviour
{
    public int edad;
    public Text Text;


    // Start is called before the first frame update
    void Start()
    {
        

        if(edad >= 18)
        {
            Text.text = "Es mayor de edad";
        }

        else
        {
            Text.text = "No es mayor de edad";
        }
    }


}
