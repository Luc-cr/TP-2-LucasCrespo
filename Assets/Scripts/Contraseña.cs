using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ValidarContraseña : MonoBehaviour
{

    string ContraseñaCorrecta;
    string ContraseñaUsuario;
    public Text IngresoUsuario;
    public Text textoMSJ;
    public GameObject cartelitoMSJ;

    // Start is called before the first frame update
    void Start()
    {
        ContraseñaCorrecta = "12345";
        cartelitoMSJ.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void validarContraseña()
    {
        ContraseñaUsuario = IngresoUsuario.text;
        if (ContraseñaUsuario == ContraseñaCorrecta)
        {
            cartelitoMSJ.SetActive(true);
            textoMSJ.text = "Bienvenido";
            Debug.Log("Bienvenido");
        }
        else
        {
            cartelitoMSJ.SetActive(true);
            textoMSJ.text = "Contraseña incorrecta";
            Debug.Log("Contraseña incorrecta");
        }
    }


}
