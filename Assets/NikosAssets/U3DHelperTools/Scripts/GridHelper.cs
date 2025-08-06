
using UnityEngine;

namespace NikosAssets.Helpers
{
    public static class GridHelper
    {
        /// <summary>
        /// </summary>
        /// <param name="chunkSize"></param>
        /// <param name="localPositionOnPlaneToAssign"></param>
        /// <returns></returns>
        public static Vector2Int CalculateLocalGridPoint(float chunkSize, Vector2 localPositionOnPlaneToAssign)
        {
            int pointX = Mathf.FloorToInt(localPositionOnPlaneToAssign.x / chunkSize);
            int pointY = Mathf.FloorToInt(localPositionOnPlaneToAssign.y / chunkSize);
            
            Vector2Int gridPoint = new Vector2Int(pointX, pointY);
            return gridPoint;
        }

        public static float GetChunkSize(float totalSize, int chunks) => totalSize / chunks;
    }
}
