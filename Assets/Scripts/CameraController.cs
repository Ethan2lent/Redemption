using UnityEngine;

public class CameraController : MonoBehaviour
{

    public float mouseSenitivity;

    void Update()
    {
        //Mouse Input
        var h = Input.GetAxisRaw("Mouse X") * mouseSenitivity;
        var v = Input.GetAxisRaw("Mouse Y") * mouseSenitivity;

        //Camera Vertical rotation
        Vector3 look = new Vector3(-v, 0, 0);
        Vector3 cameraRotation = transform.rotation.eulerAngles;
        transform.localRotation = Quaternion.Euler(cameraRotation.x + look.x,0,0);


        //Camera Horizontal rotation
        Vector3 playerTransfrom = transform.parent.rotation.eulerAngles;
        Vector3 playerLook = new Vector3(0, h, 0);
        transform.parent.rotation = Quaternion.Euler(playerTransfrom + playerLook);

    }
}
