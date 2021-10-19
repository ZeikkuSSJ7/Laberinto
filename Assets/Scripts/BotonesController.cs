using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class BotonesController : MonoBehaviour
{
    public Button botonInicio, botonControles, botonSalir;
    public Text textoControles;

    void Start()
    {
        botonInicio.onClick.AddListener(() =>
        {
            SceneManager.LoadScene(1);
        });
        botonControles.onClick.AddListener(() =>
        {
            textoControles.enabled = !textoControles.enabled;
        });
        botonSalir.onClick.AddListener(() =>
        {
            Application.Quit(0);
        });
    }
}
