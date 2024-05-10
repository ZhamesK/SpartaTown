using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField]private float cameraSpeed = 5f;

    public GameObject Player;

    // Update is called once per frame
    void Update()
    {
        Vector2 direction = Player.transform.position - this.transform.position;
        Vector2 followPlayer = new Vector2(direction.x * cameraSpeed * Time.deltaTime, direction.y * cameraSpeed * Time.deltaTime);
        this.transform.Translate(followPlayer);
    }
}
