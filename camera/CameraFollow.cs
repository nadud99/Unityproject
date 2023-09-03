using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform cameraTarget;

    [SerializeField]
    Vector3 cameraPosition;

    public float cameraMoveSpeed;
    public Vector2 offset;
    public float limitMinX, limitMaxX, limitMinY, limitMaxY;
    float cameraHalfWidth, cameraHalfHeight;

    // Start is called before the first frame update
    void Start()
    {
        cameraTarget = GameObject.Find("Player").GetComponent<Transform>();
        cameraHalfWidth = Camera.main.aspect * Camera.main.orthographicSize;
        cameraHalfHeight = Camera.main.orthographicSize;
    }

    // Update is called once per frame
    void LateUpdate()
    {
        //cameraPosition.y = 4f;
        transform.position = Vector3.Lerp(transform.position, cameraTarget.position + cameraPosition, Time.smoothDeltaTime * cameraMoveSpeed);

        float clampX = Mathf.Clamp(cameraTarget.position.x + offset.x, limitMinX + cameraHalfWidth, limitMaxX - cameraHalfWidth);
        float clampY = Mathf.Clamp(cameraTarget.position.y + offset.y, limitMinY + cameraHalfHeight, limitMaxY - cameraHalfHeight);
        transform.position = new Vector3(clampX, clampY, -10);
    }

    public void SaveCamera(){
        SaveSystem.SaveCamera(this);
    }

    public void LoadCamera(){
        CameraData data = SaveSystem.LoadCamera();

        Vector2 C_position;
        C_position.x = data.C_position[0];
        C_position.y = data.C_position[1];
        transform.position = C_position;

        limitMaxX = data.C_limitMaxX;
        limitMaxY = data.C_limitMaxY;
        limitMinX = data.C_limitMinX;
        limitMinY = data.C_limitMinY;
    }
}
