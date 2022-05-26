using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MayoriaDeEdad : MonoBehaviour
{

    public int userAge;
    public Text Text;

    // Start is called before the first frame update
    void Start()
    {
     

        if (userAge >= 18)
        {
            miTexto.text = "Es mayor de edad";   
            Debug.Log("Es mayor de edad");
        }

        else
        {
            miTexto.text = "Es menor de edad";
            Debug.Log("Es menor de edad");
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
