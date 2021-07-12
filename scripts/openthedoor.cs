using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openthedoor : MonoBehaviour
{
    public GameObject doorleft;
    public GameObject doorright;
    private void OnTriggerStay(Collider other) {
        if (other.gameObject.tag == "Player") {
            //bool x = doorleft.GetComponent<Animator>().GetBool("open");
            //bool y = doorright.GetComponent<Animator>().GetBool("open");
            //x = !x;
            //y = !y; 
            doorleft.GetComponent<Animator>().SetBool("open", true);
            doorright.GetComponent<Animator>().SetBool("open", true);
        }
    }
    private void OnTriggerExit(Collider other) {
        if (other.gameObject.tag == "Player") {
            doorleft.GetComponent<Animator>().SetBool("open", false);
            doorright.GetComponent<Animator>().SetBool("open", false);
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
