using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] GameObject cameraObject;
    [SerializeField] float rotationSpeed;


    public Texture2D cursorAimLockTexture;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.SetCursor(cursorAimLockTexture, new Vector2(cursorAimLockTexture.width / 2, cursorAimLockTexture.height / 2), CursorMode.Auto);
    }

    // Update is called once per frame
    void Update()
    {
        // Rotate camera 
        if (Input.GetAxis("Horizontal") != 0 || Input.GetAxis("Vertical") != 0)
        {
            cameraObject.transform.Rotate(Input.GetAxis("Vertical") * Time.deltaTime * rotationSpeed, -Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed, 0f);
        }

        // Clamp vertical rotation to prevent somersaulting
        cameraObject.transform.rotation = Quaternion.Euler(Mathf.Clamp(Helpers.NormalizeAngle(cameraObject.transform.rotation.eulerAngles.x), -5f, 55f), cameraObject.transform.rotation.eulerAngles.y, 0f);


    }

}
