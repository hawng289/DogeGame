using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepController : MonoBehaviour
{
    public float moveSpeed;
    Vector3 mousePos;
    float minX = -4.7f;
    float maxX = 4.7f;
    float minY = -2.6f;
    float maxY = 2.6f;
    GameObject gameController;
    // Start is called before the first frame update
    void Start()
    {
        gameController = GameObject.FindGameObjectWithTag("GameController");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            mousePos = new Vector3(Mathf.Clamp(mousePos.x, minX, maxX), Mathf.Clamp(mousePos.y, minY, maxY), 0);

        }
        transform.position = Vector3.Lerp(transform.position, mousePos, moveSpeed * Time.deltaTime);

    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(other.gameObject);
        Debug.Log(other.name);
        gameController.GetComponent<GameController>().EndGame();
    }
}
