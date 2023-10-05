using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject pnlEndGame;
    public Button btnResart;
    public Sprite btnIdle;
    public Sprite btnHover;
    public Sprite btnClick;
    public TextMeshProUGUI pointText;
    private float point = 0;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdatePoint()
    {
        point++;
        pointText.text = "Điểm: " + point;
    }

    public void StartGame(){
        SceneManager.LoadScene(0);
        pnlEndGame.SetActive(false);
    }

    public void ButtonHover()
    {
        btnResart.GetComponent<Image>().sprite = btnHover;
    }
    public void ButtonIdle()
    {
        btnResart.GetComponent<Image>().sprite = btnIdle;
    }
    public void ButtonClick()
    {
        btnResart.GetComponent<Image>().sprite = btnClick;
    }
    public void EndGame()
    {
        Time.timeScale = 0;
        pnlEndGame.SetActive(true);
    }

}
