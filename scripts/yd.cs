using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class yd : MonoBehaviour
{
    public GameObject button;
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player") {
            button.GetComponent<Animator>().SetBool("down", true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            button.GetComponent<Animator>().SetBool("down", false);
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
