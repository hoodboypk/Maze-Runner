using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    private Transform player;
    private Vector3 tempPos;

    [SerializeField]
    private float minX, maxX;

    [SerializeField]
    private float minY, maxY;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Wizard").transform;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (!player)
            return;

        tempPos = transform.position;
        tempPos.x = Mathf.Clamp(player.position.x, minX, maxX);
        tempPos.y = Mathf.Clamp(player.position.y, minY, maxY);

        transform.position = tempPos;
    }
}
