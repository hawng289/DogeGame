using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public Vector3 target;
    private float moveSpeed = 5;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((target - transform.position) * moveSpeed * Time.deltaTime);
        Debug.Log(target.ToString());
        Debug.Log(transform.position);
    }
}
