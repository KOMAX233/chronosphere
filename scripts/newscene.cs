using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class newscene : MonoBehaviour
{
    public GameObject color;
    public void OnTriggerEnter(Collider other) {
        int scene = SceneManager.GetActiveScene().buildIndex;
        if (other.gameObject.tag == "Player") {
            if (color.GetComponent<Animator>().GetInteger("color") == 1) {
                scene += 2;
            } else if (color.GetComponent<Animator>().GetInteger("color") == 0) {
                scene += 1;
            } else {
                scene += 0;
            }
            if (scene >= 3) {
                scene = 3;
            }
            SceneManager.LoadScene(scene);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
