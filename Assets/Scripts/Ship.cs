using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public Transform gameManager;
    public Transform gameCamera;

    public float speed;
    public float depth = 3;

    Vector3 relativePosition;

    Rigidbody2D rb;

    GameManager gameManagerC;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        gameManagerC = gameManager.GetComponent<GameManager>();
    }

    void Update()
    {
        if (gameManagerC.IsShowingDialog()) { return; }

        float debugPreviousSpeed = 0;

        if (Switches.debugMode && Switches.debugTurboMode)
        {
            if (Input.GetKey(KeyCode.Space))
            {
                debugPreviousSpeed = speed;
                speed *= 2;
            }
        }

        Vector3 rp = relativePosition;

        if (Input.GetKey(KeyCode.W))
            rp += Vector3.up * speed * Time.deltaTime;

        else if (Input.GetKey(KeyCode.S))
            rp -= Vector3.up * speed * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            rp += Vector3.right * speed * Time.deltaTime;

        else if (Input.GetKey(KeyCode.A))
            rp -= Vector3.right * speed * Time.deltaTime;

        rp = new Vector3(rp.x, rp.y, depth);

        relativePosition = rp;

        //transform.position = gameCamera.TransformPoint(relativePosition);
        Vector3 p = (gameCamera.TransformPoint(relativePosition));
        rb.MovePosition(p);

#if __DEBUG_AVALIABLE__
        if (Switches.debugMode && Switches.debugTurboMode)
        {
            if (Input.GetKey(KeyCode.Space))
                speed = debugPreviousSpeed;
        }
#endif

    }
}
