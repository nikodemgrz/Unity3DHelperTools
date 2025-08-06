using NaughtyAttributes;
using UnityEngine;

namespace NikosAssets.Helpers.OutOfBounds
{
    /// <summary>
    /// A very simple helper script for relatively flat environments, where if the <see cref="_target"/> falls below a certain
    /// threshold (<see cref="_outOfBoundsBelowY"/>), the <see cref="_target"/> is replaced again 
    /// </summary>
    public class OutOfBoundsBelowYHandlerMono : BaseOutOfBoundsHandlerMono
    {
        /// <summary>
        /// Reset if <see cref="_target"/> is below this threshold
        /// </summary>
        [SerializeField]
        [BoxGroup(HelperConstants.ATTRIBUTE_FIELD_BOXGROUP_SETTINGS)]
        [Tooltip("Reset if " + nameof(_target) + " is below this threshold")]
        protected float _outOfBoundsBelowY = -5;

        /// <summary>
        /// Executes the out of bounds check
        /// </summary>
        public override void Tick()
        {
            if (_target.position.y < _outOfBoundsBelowY)
                ResetPos();
        }
    }
}
