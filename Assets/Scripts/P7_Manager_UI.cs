using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class P7_Manager_UI : MonoBehaviour
{
    TextMeshProUGUI txtContador;
    float segundos;
    float auxTiempo;

    private void Awake()
    {
        txtContador = GetComponentInChildren<TextMeshProUGUI>();    
    }

    void Start()
    {
        segundos = 0;
        auxTiempo = 0;
    }

    void Update()
    {
        auxTiempo += Time.deltaTime;
        if (auxTiempo > 1.0f)
        {
            segundos++;
            auxTiempo = 0;
            txtContador.text = segundos.ToString();
        }
    }
}
