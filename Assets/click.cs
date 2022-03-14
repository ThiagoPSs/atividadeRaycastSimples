using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class click : MonoBehaviour
{
//criação de variavel
    RaycastHit hit;
    public Transform alvo;
    Renderer rend;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    // definindo a ação do click do mouse
        if (Input.GetButtonDown("Fire1"))
        {
        // colocando um raycast da camera para a direção do mouse com limite de 100 de distancia
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit, 100))
            {
                alvo.position = hit.point;
               
            }
        }
    }
}
