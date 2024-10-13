    using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Singleton : MonoBehaviour
{
    public static Singleton instance { get; private set; }
    int scene;
  

    private void Awake()
    {
        if (instance != null & instance != this)
        {
            Destroy(gameObject);
        } else
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            scene = SceneManager.GetActiveScene().buildIndex;
            if (scene < 4)
            {
                changeScene(scene + 1);
            }
        }
    }

    public void changeScene(int i)
    {
        SceneManager.LoadScene(i);
    }

    public void finalButtons(bool reiniciar = false)
    {
        if (reiniciar)
        {
            Destroy(gameObject);
        }

        scene = 1;
        changeScene(scene);
    }
}

// Si meto un script al canvas deberia el script ser singletone o como
