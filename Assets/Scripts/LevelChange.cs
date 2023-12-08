using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class LevelChange : MonoBehaviour
{
    public string playerTag = "Wizard";
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Wizard"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }
}
