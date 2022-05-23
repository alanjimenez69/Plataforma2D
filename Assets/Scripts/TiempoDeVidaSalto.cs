using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TiempoDeVidaSalto : MonoBehaviour
{
    public float TiempoDeVida;
    void Start()
    {
        Destroy(gameObject, TiempoDeVida);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
