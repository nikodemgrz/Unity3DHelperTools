using NaughtyAttributes;
using UnityEngine;

namespace NikosAssets.Helpers.OutOfBounds
{
    public class OutOfBoundsCheckGroundHandlerMono : BaseOutOfBoundsHandlerMono
    {
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        protected float _originYCheckOffset = 3;
        
        public override void Tick()
        {
            if (!Physics.Raycast(_target.position + Vector3.up * _originYCheckOffset, Vector3.down, _groundDistanceCheck, _allowedLayersToCheck))
                ResetPos();
        }
    }
}
