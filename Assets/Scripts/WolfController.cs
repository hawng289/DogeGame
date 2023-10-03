using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine;

public class WolfController : MonoBehaviour
{
    public GameObject bomb;
    private float minBombTime = 2;
    private float maxBombTime = 5;
    private float lastBombTime = 0;
    private float bombTime = 0;
    public float throughBoomTime = 0.5f;
    GameObject sheep;
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        UpdateBombTime();
        sheep = GameObject.FindGameObjectWithTag("Player");
        anim = GetComponent<Animator>();
        anim.SetBool("isBomb", false);
    }


    // Update is called once per frame
    void Update()
    {
        if (Time.time >= lastBombTime + bombTime - throughBoomTime)
        {
            anim.SetBool("isBomb", true);
        }

        if (Time.time > lastBombTime + bombTime)
        {
            ThrounghBomb();
        }
        
    }

    private void UpdateBombTime()
    {
        lastBombTime = Time.time;
        bombTime = Random.Range(minBombTime, maxBombTime + 1);
    }
    private void ThrounghBomb()
    {
        GameObject bom = Instantiate(bomb, transform.position, Quaternion.identity);
        bom.GetComponent<BombController>().target = sheep.transform.position;
        UpdateBombTime();
        anim.SetBool("isBomb", false);
    }
}
