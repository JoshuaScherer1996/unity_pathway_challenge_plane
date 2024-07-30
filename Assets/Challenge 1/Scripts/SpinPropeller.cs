using UnityEngine;

namespace Challenge_1.Scripts
{
    public class SpinPropeller : MonoBehaviour
    {
        // Initializing the constant.
        private const float RotationSpeed = 1000.0f;

        // Update is called once per frame.
        private void Update()
        {
            // Rotating the object based on the RotationSpeed.
            transform.Rotate(Vector3.forward, Time.deltaTime * RotationSpeed);
        }
    }
}
