using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelLoaderController : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            int scene = SceneManager.GetActiveScene().buildIndex + 1;
            SceneManager.LoadScene(scene <= 3 ? scene : 0);
        }
    }
}
