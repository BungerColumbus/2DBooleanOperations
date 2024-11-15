using UnityEngine;

namespace LinearAlgebra
{
    public class VectorFormulas : MonoBehaviour
    {
        // Calculates the angle between 2 3D vectors using the algebraic formula.
        protected float angleBetweenVectors(Vector3 vec1, Vector3 vec2)
        {
            return vectorMultiplication(vec1, vec2) / (vec1.magnitude * vec2.magnitude);
        }

        // Multiplies 2 vectors
        protected float vectorMultiplication(Vector3 vec1, Vector3 vec2)
        {
            return ((vec1.x * vec2.x) + (vec1.y * vec2.y) + (vec1.z * vec2.z));
        }

        protected Vector2 vector2DNormal(Vector2 vec)
        {
            return new Vector2(-vec.y, vec.x);
        }
    }
}