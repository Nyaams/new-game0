using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    [SerializeField] private float _velocity;
    [SerializeField] private float _rotationSpeed;

    [SerializeField] Animator _animator;

    private float _eulerY;
    public static float speed;
    void Update()
    {
        //if (Input.GetKey(KeyCode.W)) {        
            Vector3 newPosition = transform.position + transform.forward * (_velocity + speed) * Time.deltaTime;
            newPosition.x = Mathf.Clamp(newPosition.x, -2.8f, 2.8f);
            transform.position = newPosition;
            _animator.SetBool("Run", true);
            //transform.position += transform.forward * _velocity * Time.deltaTime;
       // }
        if (Input.GetKey(KeyCode.A)) {
            _eulerY -= (_rotationSpeed * Time.deltaTime);
            _eulerY = Mathf.Clamp(_eulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _eulerY += (_rotationSpeed * Time.deltaTime);
            _eulerY = Mathf.Clamp(_eulerY, -70, 70);
            transform.eulerAngles = new Vector3(0, _eulerY, 0);
        }
        //if(Input.GetKeyUp(KeyCode.W)) {
        //    _animator.SetBool("Run", false);
        //}
    }
}

