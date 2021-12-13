using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{

    public GameObject start_panel;
    public GameObject gameOverPanel;

    void Start()
    {
        Debug.Log(start_panel);
        gameOverPanel.gameObject.SetActive(false);
        start_panel.gameObject.SetActive(true);
    }

    public void triggerGameOver()
    {
        Player _player = FindObjectOfType<Player>();
        _player.enabled =false;
        gameOverPanel.gameObject.SetActive(true);
    }
}
