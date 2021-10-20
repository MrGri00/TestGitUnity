using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameCamera : MonoBehaviour
{
    public Transform gameManager;
    GameManager gameManagerC;

    public float speed = 1.0f;
    
    void Start()
    {
        gameManagerC = gameManager.GetComponent<GameManager>();
    }

    void Update()
    {
        if (gameManagerC.IsShowingDialog()) { return; }

        transform.position += Vector3.right * speed * Time.deltaTime;
    }
}
