using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BombController : MonoBehaviour
{
    public Vector3 target;
    public float moveSpeed = 5;
    public float destroyTime = 2;
    public GameObject explor;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(gameObject, destroyTime);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate((target - transform.position) * moveSpeed * Time.deltaTime);
       
    }

    void OnDestroy()
    {
        GameObject exp = Instantiate(explor, transform.position, Quaternion.identity) as GameObject;
        Destroy(exp, 0.5f);
    }
}
