using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTetromino : MonoBehaviour
{
    [SerializeField] private GameObject[] _tetrominoes;

    private void Start()
    {
        NewTetromino();
    }

    public void NewTetromino()
    {
        Instantiate(_tetrominoes[Random.Range(0, _tetrominoes.Length)], transform.position, Quaternion.identity);
    }
}
