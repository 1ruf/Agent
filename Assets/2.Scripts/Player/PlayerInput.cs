using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public UnityEvent<Vector2> onPointerChange;
    public Vector2 moveDir { get; private set; }
    private Camera mainCam;
    private void Start()
    {
        mainCam = Camera.main;
    }
    private void Update()
    {
        GetMouseInput();
        MoveInput();
    }

    public void MoveInput()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        moveDir = new Vector2(x, y);
    }
    public void GetMouseInput()
    {
        Vector2 mouseXY = mainCam.ScreenToWorldPoint(Input.mousePosition);
        onPointerChange?.Invoke(mouseXY);
    }
}
