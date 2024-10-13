using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class P7_Final_Buttons : MonoBehaviour
{
    Button []buttons;

    private void Awake()
    {
        buttons = GetComponentsInChildren<Button>();    
    }

    void Start()
    {
        buttons[0].onClick.AddListener(() => Singleton.instance.finalButtons());
        buttons[1].onClick.AddListener(() => Singleton.instance.finalButtons(true));
    }
}
