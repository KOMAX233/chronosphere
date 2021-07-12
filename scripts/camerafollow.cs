using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerafollow : MonoBehaviour
{
    public GameObject objectToFollow;
    public float speed = 2.0f;
    public Vector3 offset = new Vector3(0,5,-5);

    //public Transform target;
    //public float smoothing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //void LateUpdate() {
    //    if (target != null) {
    //        if (transform.position != target.position) {
    //            Vector3 targetPos = target.position;
    //            transform.position = Vector3.Lerp(transform.position, targetPos, smoothing);
    //        }
    //    }
    //}
    
    // Update is called once per frame
    void Update()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, objectToFollow.transform.position + offset, speed * Time.deltaTime);
    }
}
