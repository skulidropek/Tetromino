using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI[] _pointsText;
    [SerializeField] private static int _height = 20;
    [SerializeField] private static int _width = 10;
    [SerializeField] private float _fallTime ;

    public static GameManager instance;
    public float FallTime { get => _fallTime; set => _fallTime = value; }
    public Transform[,] Grid { get => _grid; set => _grid = value; }
    public int Height { get => _height; }
    public int Widht { get =>_width; }
    public int Points { get => _points; set => _points = value; }

    private Transform[,] _grid = new Transform[_width, _height];
   // private float _previusTime;
    private int _points;

   // private Tetromino _tetromino;

    void Awake()
    {
        if (instance == null)
            instance = this;
        else if (instance != this)
            Destroy(gameObject);

    }

    void Update()
    {
        foreach(TextMeshProUGUI _point in _pointsText)
            _point.text = $"{_points}";
    }
}
