﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Self { get; private set; }
    [SerializeField, Range(1, 10), Tooltip("Здоровье игрока")]
    private int health = 3;
    private int coinCount = 0;
    [SerializeField]
    private GameObject _coin;
    [SerializeField]
    private Transform _player;
    [SerializeField]
    private Transform[] _levels;
    [SerializeField, Space]
    private Text textScore, textHealth, textCoins, timer, resultScore, resultCoin;
    [SerializeField, Space]
    Canvas resultTable;

    void Awake()
    {
        Self = this;
    }

    private void Start()
    {
        Cursor.visible = false;
        textHealth.text = health.ToString();

        resultTable.enabled = false;
        StartCoroutine(Timer());
    }

    private void Update()
    {
        textScore.text = ((int)_player.position.z).ToString();
    }

    public void SetDamage()
    {
        health--;
        textHealth.text = health.ToString();

        if(health <= 0)
        {
            //UnityEditor.EditorApplication.isPaused = true;

            Time.timeScale = 0;
            resultScore.text = textScore.text;
            resultCoin.text = textCoins.text;
            resultTable.enabled = true;
            Cursor.visible = true;
        }
    }

    public void LoadGameScene()
    {
        var r = SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }

    public void CoinCollected(GameObject obj)
    {
        coinCount++;
        textCoins.text = coinCount.ToString();

        Destroy(obj);
    }

    private float _step = 28.8f;
    private int _currentIndex = 0;
    private float _lastZ = 172.8f;

    public void UpdateLevel()
    {
        _lastZ += _step;

        var position = _levels[_currentIndex].position;
        position.z = _lastZ;
        _levels[_currentIndex].position = position;

        Transform coins = _levels[_currentIndex].GetChild(0);

        for(int i = 0; i < coins.childCount; i++)
        {
            Transform coinPos = coins.GetChild(i);

            if (coinPos.childCount == 0)
            {
                Instantiate(_coin, coinPos);
            }
        }

        _currentIndex++;

        if(_currentIndex >= _levels.Length)
        {
            _currentIndex = 0;
        }
    }

    IEnumerator Timer()
    {
        timer.enabled = true;

        for(int i = 3; i > 0; i--)
        {
            timer.text = i.ToString();
            yield return new WaitForSeconds(1);
        }

        timer.text = "Start!";
        _player.GetComponent<PlayerController>().enabled = true;

        yield return new WaitForSeconds(1);

        timer.enabled = false;
        StopCoroutine(Timer());
    }
}