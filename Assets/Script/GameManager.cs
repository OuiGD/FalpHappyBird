using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public void startGame()
    {
        UIManager _uiManager = FindObjectOfType<UIManager>();
        _uiManager.start_panel.SetActive(false);
        Player _player = FindObjectOfType<Player>();
        _player._rigid.bodyType = RigidbodyType2D.Dynamic;
        Pipe[] _pipes = FindObjectsOfType<Pipe>();
        foreach (Pipe _pipe in _pipes)
        {
            _pipe.enabled = true;
        }

    }
    public void relaunchGame()
    {
        Player _player = FindObjectOfType<Player>();
        Checkpoint[] _checkpoints = FindObjectsOfType<Checkpoint>();
        Pipe[] _pipes = FindObjectsOfType<Pipe>();
        Score _score = FindObjectOfType<Score>();

        _score.resetScore();
        _player.enabled = true;

        foreach (Checkpoint item in _checkpoints)
        {
            item.relaunchObject();
        }
        foreach (Pipe _pipe in _pipes)
        {
            _pipe.relaunchObject();
        }
        _player.relaunchObject();

        UIManager _uiManager = FindObjectOfType<UIManager>();

        _uiManager.gameOverPanel.SetActive(false);

    }
}
