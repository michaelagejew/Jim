using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Endlevel : MonoBehaviour
{
    // Start is called before the first frame update
private void OnTriggerEnter(Collider other){

    if(other.gameObject.name == "Player")
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
}
}
