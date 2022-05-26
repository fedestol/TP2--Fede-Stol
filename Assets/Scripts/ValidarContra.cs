using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContra : MonoBehaviour
{
    string correcta;
    string contra;
    public Text ingreso;
    public GameObject msj;
    public Text txt;


    // Start is called before the first frame update
    void Start()
    {
        correcta = "12345";
        msj.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ValidarContrasenia()
    {
        contra = ingreso.text;
        if(contra == correcta)
        {
            msj.SetActive (true);
            txt.text = "Bienvenido";
        }
        else
        {
            msj.SetActive(true);
            txt.text = "Contrasena Incorrecta";
        }
    }
}
