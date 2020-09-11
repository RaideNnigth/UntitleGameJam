using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [Header("Valores do Movimento")]
    [SerializeField]
    float step;

    [Header("Componentes do Player")]
    [SerializeField]
    Rigidbody2D rb;

    [Header("Grid Configuração")]
    [SerializeField]
    int gridXSize;
    [SerializeField]
    int gridYSize;
    int[][] grid;

    Vector2 getAxis;

    

    void Start()
    {
        
    }

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        if (Input.GetKeyDown("w"))
        {
            print("chegou aqui");
            Vector2 target = new Vector2(transform.position.x, 0) + new Vector2(1, 0);
            transform.position = Vector3.MoveTowards(transform.position, target, step);
        }
    }

    void CreateGrid()
    {
        for (int i = 0; i < grid.Length; i++)
        {
            //grid[i]
        }
    }
}
