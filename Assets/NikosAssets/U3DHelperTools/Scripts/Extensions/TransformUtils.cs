using UnityEngine;

namespace NikosAssets.Helpers.Extensions
{
    public static class TransformUtils
    {
        public static void DestroyChildrenImmediate(this Transform root)
        {
            CollectionHelper.DestroyChildrenImmediate(root);
        }
        
        public static void DestroyChildren(this Transform root)
        {
            CollectionHelper.DestroyChildren(root);
        }
        
        public static void TransferChildrenToParent(this Transform oldParent, Transform newParent, bool worldPositionStays)
        {
            CollectionHelper.TransferChildrenToParent(oldParent, newParent, worldPositionStays);
        }
        
        public static void TransferChildrenToParent(this Transform newParent, Transform[] children, bool worldPositionStays)
        {
            CollectionHelper.TransferChildrenToParent(children, newParent, worldPositionStays);
        }

        public static void CopyLocalTransformValuesFrom(this Transform to, Transform from)
        {
            to.localScale = from.localScale;
            to.localRotation = from.localRotation;
            to.localPosition = from.localPosition;
        }
        
        public static void CopyGlobalTransformValuesFrom(this Transform to, Transform from)
        {
            to.localScale = from.localScale;
            to.rotation = from.rotation;
            to.position = from.position;
        }
    }
}
