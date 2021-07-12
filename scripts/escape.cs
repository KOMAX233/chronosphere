using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class escape : MonoBehaviour
{
    public GameObject wall;
    public GameObject ball;
    private void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Player") {
            wall.GetComponent<Animator>().SetBool("escape", true);
            ball.GetComponent<Animator>().SetBool("escape", true);

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
