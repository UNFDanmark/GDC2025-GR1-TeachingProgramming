using System.Numerics;
using UnityEngine;
using UnityEngine.InputSystem;
using Vector3 = UnityEngine.Vector3;

public class LookatMouse : MonoBehaviour
{

    [SerializeField] Vector3 mousepos, mpos;
    Camera cam;
    
    void Start()
    {
        cam = Camera.main;
        
    }

    void Update()
    {
        mousepos = cam.ScreenToWorldPoint((Vector3)Mouse.current.position.ReadValue() + new Vector3(0,0,44));
        mousepos.y = transform.position.y;
        transform.LookAt(mousepos);
    }
}
