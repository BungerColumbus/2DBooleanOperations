using UnityEngine;

namespace LinearAlgebra
{

    // In this script we are going to see which waypoint is the player object closer to by using vector projection.
    public class Waypoint : MonoBehaviour
    {
        public Transform player;
        public Transform debugObj;
        public Transform waypointFrom;
        public Transform waypointTo;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            player = transform;
        }

        // Update is called once per frame
        void Update()
        {
            // The vector from the initial waypoint to the player.
            Vector3 a = player.position - waypointFrom.position;

            // The vector from the initial waypoint to the end waypoint.
            Vector3 b = waypointFrom.position - waypointTo.position;

            // The vector projection formula without multiplying with vector b as a scalar
            float progress = vectorMultiplication(a, b) / vectorMultiplication(b, b);

            // Progress is going to be between -1 and 0 if the cube is between the first and second waypoint


            // The position of the debugObj is the vectorProjection added to the waypointFrom position.
            debugObj.position = progress * b + waypointFrom.position;
            
        }


        // A Vector3 method which returns the vector multiplication of 2 vectors
        float vectorMultiplication(Vector3 vec1, Vector3 vec2)
        {
            return ((vec1.x * vec2.x) + (vec1.y * vec2.y) + (vec1.z * vec2.z));
        }
    }
}