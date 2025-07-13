using UnityEngine;

public class InstantiateObjects : MonoBehaviour
{

    public GameObject obj;
    GameObject instObj;

    [SerializeField] float objVelX = 0;
    [SerializeField] float objVelZ = 0;
    [SerializeField] float objVelY = 0;
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            instObj = Instantiate(obj, transform.position + transform.forward * 1, new Quaternion());
            instObj.GetComponent<Rigidbody>().linearVelocity = objVelX * transform.forward + objVelZ * transform.right + objVelY * transform.up;
        }
    }
}
