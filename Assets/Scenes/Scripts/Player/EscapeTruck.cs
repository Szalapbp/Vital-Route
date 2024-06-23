using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeTruck : MonoBehaviour
{
    public string LevelSelect;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Truck"))
        {
            SceneManager.LoadScene(LevelSelect);
        }
    }
}
