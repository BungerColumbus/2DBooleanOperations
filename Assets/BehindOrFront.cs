using Unity.VisualScripting;
using UnityEngine;

namespace LinearAlgebra
{

    public class BehindOrFront : VectorFormulas
    {
        Transform playerTransform;
        public Transform objectTransform;

        // Start is called once before the first execution of Update after the MonoBehaviour is created
        void Start()
        {
            playerTransform = transform;
        }

        // Update is called once per frame
        void Update()
        {
            // The vector obtained by substituting the object position from the player position
            Vector3 playerEnemyVector = playerTransform.position - objectTransform.position;

            // Player's right
            Vector3 playerRight = playerTransform.right;

            // A variable to hold the vectors multiplied;
            float vectorsMultiplied = vectorMultiplication(playerEnemyVector, playerRight);


            // Normalization takes some computer time. In this case it will work perfectly without normalizing the vectors.
            if (vectorsMultiplied >= 0f)
            {
                Debug.Log("In front");
            }
            else
            {
                Debug.Log("Behind");
            }
        }

        
    }
}