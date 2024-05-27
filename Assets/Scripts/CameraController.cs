using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraController : MonoBehaviour
{


    public Transform _transform;
    public Transform cameraTransform;

    public VariableJoystick variableJoystick; //modificacao joystic

    Vector2 rotacaoMouse;
    public int sensibilidade;

    // Start is called before the first frame update
    void Start()
    {
        //UnityEngine.Cursor.lockState = CursorLockMode.Locked;
        //UnityEngine.Cursor.visible = false;
    }

    // Update is called once per frame
    void Update()
    {
        if(PlayerRigidbody.podeMover == false)
        {
            return;
        }

        Vector2 controleMouse;
        if (GameManager.gameManager.mobile)
        {
            controleMouse = new Vector2(variableJoystick.Horizontal, variableJoystick.Vertical);
        }
        else
        {
            controleMouse = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y"));
        }

        
        rotacaoMouse = new Vector2(rotacaoMouse.x + controleMouse.x * sensibilidade * Time.deltaTime, rotacaoMouse.y + controleMouse.y * sensibilidade * Time.deltaTime);
        _transform.eulerAngles = new Vector3(_transform.eulerAngles.x, rotacaoMouse.x, _transform.eulerAngles.z);
        rotacaoMouse.y = Mathf.Clamp(rotacaoMouse.y, -80, 80);


        cameraTransform.localEulerAngles = new Vector3(-rotacaoMouse.y, cameraTransform.localEulerAngles.y, cameraTransform.localEulerAngles.z);

    }
}
