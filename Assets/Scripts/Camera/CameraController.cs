using UnityEngine;

public class CameraController : MonoSingleton<CameraController>
{
    [System.Serializable]
    public class CameraSettings
    {
        [Header("CameraMoveSettings")]
        public float zoomSpeed = 5;
        public float moveSpeed = 5;
        public float rotationSpeed = 5;
        public float originalFieldOfView = 70;
        public float zoomFieldoFView = 20;
        public float MouseX_Sensitivity = 5;
        public float MouseY_Sensitivity = 5;
        public float MinClampAngle = 90;
        public float MaxClampAngle = 30;
    }
    [SerializeField]
    public CameraSettings cameraSettings;

    [System.Serializable]
    public class CameraInputSettings
    {
        public string MouseXAxis = "Mouse X";
        public string MouseYAxis = "Mouse Y";
        public string AimInput = "Fire2";
    }

    [SerializeField]
    public CameraInputSettings cameraInputSettings;

    private Transform center;
    [SerializeField] private Transform target;

    private Camera mainCam;
    private float cameraXRotation = 0;
    private float cameraYRotation = 0;

    private void Start()
    {
        mainCam = Camera.main;
        center = transform.GetChild(0);
    }

    private void Update()
    {

    }
    private void LateUpdate()
    {
          
    }

    private void FollowPlayer()
    {
        Vector3 moveCam = Vector3.Lerp(transform.position, target.transform.position, cameraSettings.moveSpeed * Time.deltaTime);
        
    }
}
