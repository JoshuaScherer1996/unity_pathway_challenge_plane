using UnityEngine;

namespace Challenge_1.Scripts
{
    public class PlayerControllerX : MonoBehaviour
    {
        // Declaring and initializing the variables.
        public float speed;
        public float rotationSpeed;
        public float verticalInput;

        // Update is called once per frame.
        private void FixedUpdate()
        {
            // Get the user's vertical input.
            verticalInput = Input.GetAxis("Vertical");

            // Move the plane forward at a constant rate.
            transform.Translate(Vector3.forward * speed);

            // Tilt the plane up/down based on up/down arrow keys.
            transform.Rotate(Vector3.right * (rotationSpeed * Time.deltaTime * verticalInput));
        }
    }
}
