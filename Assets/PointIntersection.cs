using UnityEngine;

namespace LinearAlgebra
{
    public class PointIntersection : VectorFormulas
    {
        public Transform[] pointAsTransform = new Transform[4];
        public Vector2[] pointAsVector = new Vector2[4];

        void Update()
        {
            //To avoid floating point precision issues I added a small value
            float epsilon = 0.00001f;

            for (int i = 0; i < pointAsVector.Length; i++)
            {
                pointAsVector[i] = pointAsTransform[i].transform.position;
            }

            float denominator = (pointAsVector[3].y - pointAsVector[2].y) * (pointAsVector[1].x - pointAsVector[0].x)
                              - (pointAsVector[3].x - pointAsVector[2].x) * (pointAsVector[1].y - pointAsVector[0].y);

            //If the denominator is not 0, than the lines are not parallel
            if (denominator != 0f)
            {
                float parameter1 = ((pointAsVector[3].x - pointAsVector[2].x) * (pointAsVector[0].y - pointAsVector[2].y)
                                 - (pointAsVector[3].y - pointAsVector[2].y) * (pointAsVector[0].x - pointAsVector[2].x)) 
                                 / denominator;
                float parameter2 = ((pointAsVector[1].x - pointAsVector[0].x) * (pointAsVector[0].y - pointAsVector[2].y) 
                                 - (pointAsVector[1].y - pointAsVector[0].y) * (pointAsVector[0].x - pointAsVector[2].x)) 
                                 / denominator;

                //Is intersecting if parameter1 and parameter2 are between 0 and 1 or exactly 0 or 1
                if (parameter1 >= 0f + epsilon && parameter1 <= 1f - epsilon && parameter2 >= 0f + epsilon && parameter2 <= 1f - epsilon)
                {
                    Vector2 intersectPoint = new Vector2(pointAsVector[0].x + parameter1 * (pointAsVector[1].x - pointAsVector[0].x), 
                                                        (pointAsVector[0].y + parameter1 * (pointAsVector[1].y - pointAsVector[0].y)));
                    transform.position = intersectPoint;
                }
            }
        }
    }
}
