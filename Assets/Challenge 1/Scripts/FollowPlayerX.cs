using UnityEngine;

namespace Challenge_1.Scripts
{
    public class FollowPlayerX : MonoBehaviour
    {
        // Declaring and initializing the variables.
        public GameObject plane;
        private readonly Vector3 _offset = new Vector3(30, 0, 0);

        // Update is called once per frame.
        private void Update()
        {
            // Position the object based on the plane + the given _offset.
            transform.position = plane.transform.position + _offset;
        }
    }
}
