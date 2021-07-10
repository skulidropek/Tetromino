using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTetromino : MonoBehaviour
{
    [SerializeField] private GameObject[] _tetrominoes;
    [SerializeField] private Vector3 testVector;

    private static int _index;
    private GameObject _tetromino;
    private GameObject _tetrominoImage;


    private void Start()
    {
        //_tetrominoesImages = _tetrominoes;
        NewTetromino();
    }

    private void OnDisable()
    {
        foreach(GameObject tetromino in _tetrominoes)
            tetromino.GetComponent<Tetromino>().enabled = true;
    }

    public void NewTetromino()
    {
        if (_tetromino != null)
            _tetromino.GetComponent<Tetromino>().enabled = true;
        else
            _tetromino = _tetrominoes[Random.Range(0, _tetrominoes.Length)];

        Destroy(_tetrominoImage);

        Instantiate(_tetromino, transform.position, Quaternion.identity);

        _index = Random.Range(0, _tetrominoes.Length);

        _tetrominoImage = _tetrominoes[_index];

        _tetromino = _tetrominoImage;

        _tetrominoImage.GetComponent<Tetromino>().enabled = false;

        _tetrominoImage = Instantiate(_tetrominoImage, testVector, Quaternion.identity);
    }
}
